/// © 2023 by xscr33m   (Discord: xscr33m#4443)  
using System.Drawing;
using System.Windows.Forms;

namespace TraderPlusEditor
{
    public class CustomMenuRenderer : ToolStripProfessionalRenderer
    {
        public CustomMenuRenderer() : base(new CustomColorTable()) { }

        protected override void OnRenderMenuItemBackground(ToolStripItemRenderEventArgs e)
        {
            if (e.Item.Pressed)
            {
                Rectangle rc = new Rectangle(Point.Empty, e.Item.Size);
                Color c = Color.FromArgb(230, 230, 230);
                using (SolidBrush brush = new SolidBrush(c))
                {
                    e.Graphics.FillRectangle(brush, rc);
                }
            }
            if (e.Item.Selected)
            {
                Rectangle rc = new Rectangle(Point.Empty, e.Item.Size);
                Color c = Color.FromArgb(235, 235, 235);
                using (SolidBrush brush = new SolidBrush(c))
                {
                    e.Graphics.FillRectangle(brush, rc);
                }
                Color borderColor = Color.LightGray;
                using (Pen pen = new Pen(borderColor))
                {
                    Rectangle rect = new Rectangle(0, 0, e.Item.Bounds.Width - 1, e.Item.Bounds.Height - 1);
                    e.Graphics.DrawRectangle(pen, rect);
                }
            }
        }

        protected override void OnRenderToolStripBorder(ToolStripRenderEventArgs e)
        {
            if (e.ToolStrip.GetType() == typeof(ToolStripDropDownMenu))
            {
                Color borderColor = Color.LightGray;
                using (Pen pen = new Pen(borderColor))
                {
                    e.Graphics.DrawRectangle(pen, new Rectangle(0, 0, e.AffectedBounds.Width - 1, e.AffectedBounds.Height - 1));
                }
            }

            else if (e.ToolStrip.GetType() == typeof(ContextMenuStrip))
            {
                Color borderColor = Color.LightGray;
                using (Pen pen = new Pen(borderColor))
                {
                    e.Graphics.DrawRectangle(pen, new Rectangle(0, 0, e.AffectedBounds.Width - 1, e.AffectedBounds.Height - 1));
                }
            }
        }

        protected override void OnRenderImageMargin(ToolStripRenderEventArgs e)
        {
            base.OnRenderImageMargin(e);
            using (SolidBrush brush = new SolidBrush(Color.FromArgb(255, 255, 255)))
            {
                e.Graphics.FillRectangle(brush, e.AffectedBounds);
            }
        }
    }

    public class CustomColorTable : ProfessionalColorTable
    {
        public override Color MenuItemSelected
        {
            get { return Color.FromArgb(235, 235, 235); }
        }
    }
}
