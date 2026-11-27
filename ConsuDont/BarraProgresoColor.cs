using System;
using System.ComponentModel;
using System.Drawing;
using System.Windows.Forms;

public class BarraProgresoColor : Control
{
    private int _minimo = 0;
    private int _maximo = 100;
    private int _valor = 0;
    private Color _colorBarra = Color.DodgerBlue;
    private Color _colorFondo = Color.Gainsboro;
    private Color _colorBorde = Color.Silver;

    public BarraProgresoColor()
    {
        SetStyle(
            ControlStyles.UserPaint |
            ControlStyles.AllPaintingInWmPaint |
            ControlStyles.OptimizedDoubleBuffer |
            ControlStyles.ResizeRedraw,
            true);

        Size = new Size(250, 24);
    }

    [Category("Comportamiento"), DefaultValue(0)]
    public int Minimum
    {
        get => _minimo;
        set
        {
            _minimo = value;
            if (_maximo < _minimo) _maximo = _minimo;
            Value = _valor; // Reajusta dentro del nuevo rango
            Invalidate();
        }
    }

    [Category("Comportamiento"), DefaultValue(100)]
    public int Maximum
    {
        get => _maximo;
        set
        {
            _maximo = value < _minimo ? _minimo : value;
            Value = _valor; // Reajusta dentro del nuevo rango
            Invalidate();
        }
    }

    [Category("Comportamiento"), DefaultValue(0)]
    public int Value
    {
        get => _valor;
        set
        {
            // Evita excepciones si el valor se sale del rango permitido
            if (value < _minimo) _valor = _minimo;
            else if (value > _maximo) _valor = _maximo;
            else _valor = value;

            Invalidate();
        }
    }

    [Category("Apariencia")]
    public Color BarColor
    {
        get => _colorBarra;
        set
        {
            _colorBarra = value;
            Invalidate();
        }
    }

    [Category("Apariencia")]
    public Color TrackColor
    {
        get => _colorFondo;
        set
        {
            _colorFondo = value;
            Invalidate();
        }
    }

    [Category("Apariencia")]
    public Color BorderColor
    {
        get => _colorBorde;
        set
        {
            _colorBorde = value;
            Invalidate();
        }
    }

    protected override void OnPaint(PaintEventArgs e)
    {
        base.OnPaint(e);

        if (Width <= 2 || Height <= 2) return;

        Graphics g = e.Graphics;
        g.SmoothingMode = System.Drawing.Drawing2D.SmoothingMode.None;

        Rectangle rectFondo = new Rectangle(0, 0, Width - 1, Height - 1);

        using (SolidBrush brochaFondo = new SolidBrush(_colorFondo))
        {
            g.FillRectangle(brochaFondo, rectFondo);
        }

        int rango = _maximo - _minimo;
        if (rango > 0 && _valor > _minimo)
        {
            double porcentaje = (double)(_valor - _minimo) / rango;
            int anchoUtil = Math.Max(0, Width - 2);
            int anchoBarra = (int)Math.Round(porcentaje * anchoUtil);

            if (anchoBarra > 0)
            {
                Rectangle rectBarra = new Rectangle(1, 1, anchoBarra, Math.Max(1, Height - 2));
                using (SolidBrush brochaBarra = new SolidBrush(_colorBarra))
                {
                    g.FillRectangle(brochaBarra, rectBarra);
                }
            }
        }

        using (Pen lapizBorde = new Pen(_colorBorde, 1))
        {
            g.DrawRectangle(lapizBorde, rectFondo);
        }
    }
}