using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Threading;
using System.Windows.Forms;

namespace FlatUI.Examples
{
	public partial class BasicExample : Form
	{
		private Boolean ProgressOngoing = false;

		public BasicExample()
		{
			InitializeComponent();
		}

		private void FlatButton_Click(object sender, EventArgs e)
		{
			if (!this.ProgressOngoing)
			{
				Int32 sleepAmount = (this.ProgressCheckBox.Checked ? 30 : 10);
				this.ProgressOngoing = true;
				this.FlatProgressBar.Value = 0;
				new Thread(() =>
				{
					while (this.FlatProgressBar.Value < this.FlatProgressBar.Maximum)
					{
						Thread.Sleep(sleepAmount);
						this.Invoke((MethodInvoker)delegate
						{
							this.FlatProgressBar.Increment(1);
						});
					}

					this.ProgressOngoing = false;
				}).Start();
			}
		}

		private void SpawnAlertButton_Click(object sender, EventArgs e)
		{
			this.FlatAlertBox.Visible = false;
			FlatAlertBox._Kind kind = this.GetAlertBoxKind();
			this.FlatAlertBox.kind = kind;
			this.FlatAlertBox.Visible = true;
		}

		/// <summary>
		/// Get the alert box type from the radio buttons.
		/// </summary>
		/// <returns>Alert box kind</returns>
		private FlatAlertBox._Kind GetAlertBoxKind()
		{
			if (this.SuccessRadioButton.Checked)
				return FlatUI.FlatAlertBox._Kind.Success;
			else if (this.ErrorRadioButton.Checked)
				return FlatUI.FlatAlertBox._Kind.Error;
			else return FlatUI.FlatAlertBox._Kind.Info;
		}

        private void FlatToggleStyle2_CheckedChanged(object sender)
        {

        }

        private void FormSkin_Click(object sender, EventArgs e)
        {

        }

        private void FlatClose_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

        private void Tab2Button_Click(object sender, EventArgs e)
        {
            Form2 f2 = new Form2();
            f2.Show();
     
        }

        private void flatClose1_Click(object sender, EventArgs e)
        {

        }
    }
}
