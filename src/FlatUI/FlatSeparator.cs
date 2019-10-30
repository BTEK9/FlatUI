using System;
using System.ComponentModel;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Drawing.Text;
using System.Windows.Forms;

public partial class FlatSeparator : UserControl

{

    public FlatSeparator()

    {
 

        this.Paint += new PaintEventHandler(FlatSeparator_Paint);

        this.MaximumSize = new Size(2000, 2);

        this.MinimumSize = new Size(0, 2);

        this.Width = 350;
       

    }

    private void FlatSeparator_Paint(object sender, PaintEventArgs e)

    {

        Graphics g = e.Graphics;


        this.BackColor = Color.FromArgb(35, 168, 109);
     

    }

    private void InitializeComponent()
    {
            this.SuspendLayout();
            // 
            // LineSeparator
            // 
            this.Name = "FlatSeparator";
            this.Size = new System.Drawing.Size(839, 10);
            this.ResumeLayout(false);

    }
}


