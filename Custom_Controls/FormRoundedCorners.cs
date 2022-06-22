using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.Windows.Forms;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.ComponentModel;

namespace phd_project_net_framework.Custom_Controls
{
    //
    // Summary: Panel with rounded corners
    //
    public class PanelRoundedCorners : Panel
    {
        // Fields of the class
        private int borderSize = 0;
        private int borderRadius = 20;
        private Color _borderColor = Color.PaleVioletRed;


        // Properties of the class
        [Category("Appearance")]
        [Description("Border color of the control")]
        [Browsable(true)]
        [DefaultValue(0)]
        public Color BorderColor
        {
            get => _borderColor;
            set
            {
                _borderColor = value;
                this.Invalidate();
            }
        }
        [Category("Appearance")]
        [Description("Border size of the control")]
        [Browsable(true)]
        [DefaultValue(0)]
        public int BorderSize
        {
            get { return borderSize; }
            set { borderSize = value; }
        }

        [Category("Appearance")]
        [Description("Border radius of the control")]
        [Browsable(true)]
        [DefaultValue(20)]
        public int BorderRadius
        {
            get { return borderRadius; }
            set { borderRadius = value; }
        }
        public PanelRoundedCorners()
        {
            //this.SetStyle(ControlStyles.SupportsTransparentBackColor, true);
            //this.SetStyle(ControlStyles.Opaque, true);
            this.BorderSize = 0;
            this.BackColor = Color.MidnightBlue;
            this.ForeColor = Color.White;

        }

        // Methods of the class
        protected override void OnPaint(PaintEventArgs e)
        {
            base.OnPaint(e);
            Rectangle rectSurface = this.ClientRectangle;
            Rectangle rectBorder = Rectangle.Inflate(rectSurface, -BorderSize, -BorderSize);
            int smoothSize = 2;
            if (BorderSize > 0)
                smoothSize = BorderSize;

            if (BorderRadius > 2) //Rounded button
            {
                using (GraphicsPath pathSurface = GetRoundedCornersPath(rectSurface, BorderRadius))
                using (GraphicsPath pathBorder = GetRoundedCornersPath(rectBorder, BorderRadius - BorderSize))
                using (Pen penSurface = new Pen(this.Parent.BackColor, smoothSize))
                using (Pen penBorder = new Pen(BorderColor, BorderSize))
                {
                    e.Graphics.SmoothingMode = SmoothingMode.AntiAlias;
                    //Button surface
                    this.Region = new Region(pathSurface);
                    //Draw surface border for HD result
                    e.Graphics.DrawPath(penSurface, pathSurface);
                    //Button border                    
                    if (BorderSize >= 1)
                        //Draw control border
                        e.Graphics.DrawPath(penBorder, pathBorder);
                }
            }
            else //Normal button
            {
                e.Graphics.SmoothingMode = SmoothingMode.None;
                //Button surface
                this.Region = new Region(rectSurface);
                //Button border
                if (BorderSize >= 1)
                {
                    using (Pen penBorder = new Pen(BorderColor, BorderSize))
                    {
                        penBorder.Alignment = PenAlignment.Inset;
                        e.Graphics.DrawRectangle(penBorder, 0, 0, this.Width - 1, this.Height - 1);
                    }
                }
            }

        }

        private GraphicsPath GetRoundedCornersPath(Rectangle rect, int radius)
        {
            GraphicsPath path = new GraphicsPath();

            float curveSize = radius * 2F;
            path.StartFigure();
            path.AddArc(rect.X, rect.Y, curveSize, curveSize, 180, 90);
            path.AddArc(rect.Right - curveSize, rect.Y, curveSize, curveSize, 270, 90);
            path.AddArc(rect.Right - curveSize, rect.Bottom - curveSize, curveSize, curveSize, 0, 90);
            path.AddArc(rect.X, rect.Bottom - curveSize, curveSize, curveSize, 90, 90);
            path.CloseFigure();
            return path;
        }

/*        protected override void OnHandleCreated(EventArgs e)
        {
            base.OnHandleCreated(e);
            this.Parent.BackColorChanged += new EventHandler(Container_BackColorChanged);
        }

        private void Container_BackColorChanged(object sender, EventArgs e)
        {
            this.Invalidate();
        }*/
    }
}
