using System;
using System.Drawing;
using System.Windows.Forms;

public class ModernProgressBar : ProgressBar
{
    public Color FillColor { get; set; } = Color.DodgerBlue;
    public Color TrackColor { get; set; } = Color.FromArgb(225, 238, 250);
    public Color BorderColor { get; set; } = Color.FromArgb(144, 202, 249);

    public ModernProgressBar()
    {
        SetStyle(ControlStyles.UserPaint | ControlStyles.AllPaintingInWmPaint | ControlStyles.OptimizedDoubleBuffer, true);
    }

    protected override void OnPaint(PaintEventArgs e)
    {
        Rectangle rect = ClientRectangle;
        Graphics g = e.Graphics;

        // Fondo de la barra
        using (SolidBrush trackBrush = new SolidBrush(TrackColor))
        {
            g.FillRectangle(trackBrush, rect);
        }

        // Relleno según el progreso actual
        int range = Maximum - Minimum;
        if (range > 0 && Value > Minimum)
        {
            float percent = (float)(Value - Minimum) / range;
            int fillWidth = (int)(rect.Width * percent);

            if (fillWidth > 0)
            {
                using (SolidBrush fillBrush = new SolidBrush(FillColor))
                {
                    g.FillRectangle(fillBrush, 0, 0, fillWidth, rect.Height);
                }
            }
        }

        // Borde limpio
        using (Pen borderPen = new Pen(BorderColor, 1))
        {
            g.DrawRectangle(borderPen, 0, 0, rect.Width - 1, rect.Height - 1);
        }
    }
}