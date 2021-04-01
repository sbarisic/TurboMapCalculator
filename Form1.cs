using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Numerics;

namespace TurboMapCalculator {
	public partial class Form1 : Form {
		public EditProps Props = new EditProps();

		PictureBox Overlay;
		Bitmap OverlayBmp;


		public Form1() {
			InitializeComponent();
		}

		private void pictureBox1_Click(object sender, EventArgs e) {

		}

		private void Form1_Load(object sender, EventArgs e) {
			propGrid.SelectedObject = Props;
			propGrid.PropertyValueChanged += PropGrid_PropertyValueChanged;

			DragDrop += Form1_DragDrop;
		}

		private void Form1_DragDrop(object sender, DragEventArgs e) {

		}

		private void PropGrid_PropertyValueChanged(object s, PropertyValueChangedEventArgs e) {
		}

		private void btnRecalc_Click(object sender, EventArgs e) {
			Draw((G) => {
				G.Clear(Color.Transparent);

				G.FillRectangle(Brushes.Red, new RectangleF(Props.BottomLeft.X, Props.BottomLeft.Y, 10, 10));
			});
		}

		private void btnPasteImage_Click(object sender, EventArgs e) {
			if (!Clipboard.ContainsImage())
				return;

			Image Img = Clipboard.GetImage();
			pictureBox1.Image = Img;
			pictureBox1.SizeMode = PictureBoxSizeMode.AutoSize;

			OverlayBmp = new Bitmap(Img.Width, Img.Height);

			if (Overlay == null) {
				Overlay = new PictureBox();
				Controls.Add(Overlay);
				Overlay.Parent = pictureBox1;
			}

			Overlay.Size = pictureBox1.Size;
			Overlay.BringToFront();

			Overlay.BackColor = Color.Transparent;
		}

		void Draw(Action<Graphics> A) {
			using (Graphics Gfx = Graphics.FromImage(OverlayBmp)) {
				A(Gfx);
				Gfx.Flush();
			}

			Overlay.Image = OverlayBmp;
		}
	}

	public class EditProps {
		[Category("Compressor Map")]
		public Point BottomLeft {
			get; set;
		}

		[Category("Engine")]
		[DisplayName("Displacement")]
		[Description("Displacement [L]")]
		public float Displacement {
			get; set;
		} = 1.4f;
	}
}
