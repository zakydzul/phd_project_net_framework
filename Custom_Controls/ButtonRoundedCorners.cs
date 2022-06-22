using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.Windows.Forms;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.ComponentModel;

namespace phd_project_net_framework
{
    public class ButtonRoundedCorners : Button
    {
        

        //Fields of rounded corners
        private int borderSize = 0;
        private int borderRadius = 20;
        private Color _borderColor = Color.PaleVioletRed;

        // properties
        [Category("Advanced Options")]
        public int BorderSize
        {
            get => borderSize;
            set
            {
                borderSize = value;
                this.Invalidate();
            }
        }
        [Category("Advanced Options")]
        public int BorderRadius
        { 
            get => borderRadius;
            set
            {
                borderRadius = value;
                this.Invalidate();
            } 
        }
        [Category("Advanced Options")]
        public Color BorderColor
        {
            get => _borderColor;
            set
            {
                _borderColor = value;
                this.Invalidate();
            }
        }
        [Category("Advanced Options")]
        public Color BackgroundColor
        {
            get { return this.BackColor; }
            set { this.BackColor = value; }
        }
        [Category("Advanced Options")]        
        public Color TextColor
        {
            get { return this.ForeColor; }
            set { this.ForeColor = value; }
        }

        // constuctor
        public ButtonRoundedCorners()
        {
            this.FlatStyle = FlatStyle.Flat;
            this.FlatAppearance.BorderSize = 0;
            this.FlatAppearance.BorderColor = Color.FromArgb(0, 255, 255, 255);
            this.Size = new Size(150, 40);
            this.BackColor = Color.MidnightBlue;
            this.ForeColor = Color.White;
        }

        // methods to create button
        private GraphicsPath GetFigurePath(RectangleF rect, float radius)
        {
            // create a GraphicsPath object
            GraphicsPath path = new GraphicsPath();
            // create a rectangle for the path
            float curveSize = radius * 2F;
            path.StartFigure();
            path.AddArc(rect.X, rect.Y, curveSize, curveSize, 180, 90);
            path.AddArc(rect.Right - curveSize, rect.Y, curveSize, curveSize, 270, 90);
            path.AddArc(rect.Right - curveSize, rect.Bottom - curveSize, curveSize, curveSize, 0, 90);
            path.AddArc(rect.X, rect.Bottom - curveSize, curveSize, curveSize, 90, 90);
            path.CloseFigure();
            return path;

        }
        // overide method to paint
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
                using (GraphicsPath pathSurface = GetFigurePath(rectSurface, BorderRadius))
                using (GraphicsPath pathBorder = GetFigurePath(rectBorder, BorderRadius - BorderSize))
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

        // over ride method to set border color
        protected override void OnHandleCreated(EventArgs e)
        {
            base.OnHandleCreated(e);
            this.Parent.BackColorChanged += new EventHandler(Container_BackColorChanged);
        }

        private void Container_BackColorChanged(object sender, EventArgs e)
        {
            this.Invalidate();
        }
    }
}
