using System;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Drawing.Imaging;
using System.Windows.Forms;


namespace SimplePaint
{
    public partial class Form1 : Form
    {
        // --- ПЕРЕМЕННЫЕ ---
        private Bitmap _bitmap;           // Основной слой (сохраненный рисунок)
        private Graphics _graphics;       // Графика для Bitmap
        private Point _startPoint;        // Точка нажатия
        private Point _currentPoint;      // Текущая точка мыши
        private bool _isDrawing = false;

        private Tool _currentTool = Tool.Pen; // Текущий инструмент
        private Color _currentColor = Color.Black;
        private int _currentSize = 5;

        public Form1()
        {
            InitializeComponent();
            InitializeDrawingSurface();
        }

        private void InitializeDrawingSurface()
        {
            // Создаем холст
            int width = pictureBox1.Width > 0 ? pictureBox1.Width : 800;
            int height = pictureBox1.Height > 0 ? pictureBox1.Height : 600;

            _bitmap = new Bitmap(width, height);
            _graphics = Graphics.FromImage(_bitmap);
            _graphics.Clear(Color.White);
            _graphics.SmoothingMode = SmoothingMode.AntiAlias;

            pictureBox1.Image = _bitmap;

            // Настройка дефолтных значений UI
            btnColor.BackColor = _currentColor;
        }

        // --- СОБЫТИЯ МЫШИ ---

        private void pictureBox1_MouseDown(object sender, MouseEventArgs e)
        {
            _isDrawing = true;
            _startPoint = e.Location;
            _currentPoint = e.Location; // Инициализируем, чтобы не было скачка
        }

        private void pictureBox1_MouseMove(object sender, MouseEventArgs e)
        {
            if (!_isDrawing) return;

            _currentPoint = e.Location;

            // Если это Карандаш или Ластик - рисуем СРАЗУ в Bitmap
            if (_currentTool == Tool.Pen || _currentTool == Tool.Eraser)
            {
                Pen p = GetCurrentPen();
                _graphics.DrawLine(p, _startPoint, _currentPoint);
                _startPoint = _currentPoint; // Перемещаем начало для следующего сегмента
                p.Dispose(); // Обязательно освобождаем ресурсы пера
            }

            // Для фигур мы просто вызываем перерисовку экрана (сработает событие Paint)
            // Это создаст эффект "превью" без сохранения в Bitmap
            pictureBox1.Invalidate();
        }

        private void pictureBox1_MouseUp(object sender, MouseEventArgs e)
        {
            if (_isDrawing)
            {
                // Если рисовали фигуру, то в момент отпускания мыши 
                // фиксируем её окончательно в Bitmap
                if (_currentTool == Tool.Line || _currentTool == Tool.Rectangle || _currentTool == Tool.Ellipse)
                {
                    DrawShape(_graphics); // Рисуем в память
                }
            }
            _isDrawing = false;
        }

        // --- ОТРИСОВКА ПРЕВЬЮ (Визуализация в реальном времени) ---

        // Это событие вызывается каждый раз при pictureBox1.Invalidate()
        private void pictureBox1_Paint(object sender, PaintEventArgs e)
        {
            // Если мы сейчас тянем мышь и рисуем ФИГУРУ
            if (_isDrawing && (_currentTool == Tool.Line || _currentTool == Tool.Rectangle || _currentTool == Tool.Ellipse))
            {
                // Рисуем на экране (e.Graphics), а не в Bitmap
                e.Graphics.SmoothingMode = SmoothingMode.AntiAlias;
                DrawShape(e.Graphics);
            }
        }

        // --- ВСПОМОГАТЕЛЬНЫЕ МЕТОДЫ ---

        private Pen GetCurrentPen()
        {
            // Если ластик, цвет белый, иначе текущий
            Color c = (_currentTool == Tool.Eraser) ? Color.White : _currentColor;
            Pen p = new Pen(c, _currentSize);
            p.StartCap = LineCap.Round;
            p.EndCap = LineCap.Round;
            return p;
        }

        private void DrawShape(Graphics g)
        {

            Pen p = GetCurrentPen();

            if (_currentTool == Tool.Line)
            {
                g.DrawLine(p, _startPoint, _currentPoint);
            }
            else if (_currentTool == Tool.Rectangle)
            {
                Rectangle r = GetRect(_startPoint, _currentPoint);
                g.DrawRectangle(p, r);
            }
            else if (_currentTool == Tool.Ellipse)
            {
                Rectangle r = GetRect(_startPoint, _currentPoint);
                g.DrawEllipse(p, r);
            }
            p.Dispose();
        }

        // Метод для создания правильного прямоугольника (работает во все стороны)
        private Rectangle GetRect(Point p1, Point p2)
        {
            int x = Math.Min(p1.X, p2.X);
            int y = Math.Min(p1.Y, p2.Y);
            int width = Math.Abs(p1.X - p2.X);
            int height = Math.Abs(p1.Y - p2.Y);
            return new Rectangle(x, y, width, height);
        }

        // --- UI СОБЫТИЯ ---

        private void btnTool_Click(object sender, EventArgs e)
        {
            // Общий обработчик для кнопок инструментов
            Button btn = sender as Button;
            if (btn != null)
            {
                // Используем Tag кнопки или её имя для определения инструмента
                // Здесь для простоты проверим текст или имя
                switch (btn.Text)
                {
                    case "Карандаш": _currentTool = Tool.Pen; break;
                    case "Ластик": _currentTool = Tool.Eraser; break;
                    case "Линия": _currentTool = Tool.Line; break;
                    case "Квадрат": _currentTool = Tool.Rectangle; break;
                    case "Круг": _currentTool = Tool.Ellipse; break;
                }
            }
        }

        private void btnColor_Click(object sender, EventArgs e)
        {
            ColorDialog cd = new ColorDialog();
            if (cd.ShowDialog() == DialogResult.OK)
            {
                _currentColor = cd.Color;
                btnColor.BackColor = _currentColor;
            }
        }

        private void trackBarSize_Scroll(object sender, EventArgs e)
        {
            _currentSize = trackBarSize.Value;
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            _graphics.Clear(Color.White);
            pictureBox1.Invalidate();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            SaveFileDialog sfd = new SaveFileDialog();
            sfd.Filter = "PNG|*.png|JPEG|*.jpg";
            if (sfd.ShowDialog() == DialogResult.OK)
            {
                _bitmap.Save(sfd.FileName);
            }
        }
    }
}