using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

using System.Drawing.Drawing2D;

namespace howto_graph_conic_section
{
    public partial class Form1 : Form
    {
        private float xcent = 0, lx = 0, ycent = 0, ly = 0, scale = 0.0419466f, fx, fy, acc;
        private float x1, y1, m;
        private int lastWidth, lastHeight;
        private bool drawed = false, clickIn = false, drln = false;

        private List<PointF> lp1 = new List<PointF>(), lp2 = new List<PointF>(), mp1 = new List<PointF>(), mp2 = new List<PointF>();

        public Form1()
        {
            InitializeComponent();
        }

        private void changeAcc(object sender, EventArgs e)
        {
            try
            {
                acc = (float.Parse(accur.Text) > 0) ? float.Parse(accur.Text) : acc;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error reading accuration\n" + ex.Message);
            }
            Debug.Print("{0}", acc);
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            acc = float.Parse(accur.Text);
            // A sample hyperbola.
            txtA.Text = "3";
            txtB.Text = "0";
            txtC.Text = "16";
            txtD.Text = "0";
            txtE.Text = "0";
            txtF.Text = "-48";

            coor.Text = "2,1.5";

            lastWidth = picGraph.Width;
            lastHeight = picGraph.Height;
        }

        // Draw the graph.
        private void btnGraph_Click(object sender, EventArgs e)
        {
            drawed = true;
            DrawGraph();
        }

        // Draw the graph.
        private void DrawGraph()
        {
            if (!drawed) goto end;
            Bitmap bm = new Bitmap(
                picGraph.ClientSize.Width,
                picGraph.ClientSize.Height);
            using (Graphics gr = Graphics.FromImage(bm))
            {
                gr.Clear(picGraph.BackColor);
                gr.SmoothingMode = SmoothingMode.AntiAlias;

                // Get the parameters.
                float A, B, C, D, E, F;
                try
                {
                    A = float.Parse(txtA.Text);
                    B = float.Parse(txtB.Text);
                    C = float.Parse(txtC.Text);
                    D = float.Parse(txtD.Text);
                    E = float.Parse(txtE.Text);
                    F = float.Parse(txtF.Text);
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error reading parameters.\n" + ex.Message);
                    return;
                }

                using (Pen thin_pen = new Pen(Color.Black, 1))
                {
                    gr.DrawLine(thin_pen, 0, picGraph.Height / 2 - ycent, picGraph.Width, picGraph.Height / 2 - ycent); // Axis
                    gr.DrawLine(thin_pen, picGraph.Width / 2 + xcent, 0, picGraph.Width / 2 + xcent, picGraph.Height); // Ordinate
                }

                if (!drln) goto dcs;
                using (Pen thin_pen = new Pen(Color.Purple, 2))
                {
                    try { if (lp1.Count > 0) gr.DrawLines(thin_pen, lp1.ToArray()); }
                    catch { }

                    thin_pen.Color = Color.DarkGray;
                    try { if (lp2.Count > 0) gr.DrawLines(thin_pen, lp2.ToArray()); }
                    catch { }

                    thin_pen.Color = Color.Cyan;
                    try { if (mp1.Count > 0) gr.DrawLines(thin_pen, mp1.ToArray()); }
                    catch { }

                    thin_pen.Color = Color.DarkMagenta;
                    try { if (mp2.Count > 0) gr.DrawLines(thin_pen, mp2.ToArray()); }
                    catch { }
                }

                dcs:;
                DrawConicSection(gr, A, B, C, D, E, F);
            }

            // Display the result.
            picGraph.Image = bm;
            end:;
        }

        // Draw the conic section.
        private void DrawConicSection(Graphics gr,
            float A, float B, float C, float D, float E, float F)
        {
            // Get the X coordinate bounds.
            float edge = picGraph.ClientSize.Width * scale;
            float xmin = -edge - xcent * scale;
            float xmax = edge - xcent * scale;

            // Find the smallest X coordinate with a real value.
            for (float x = xmin; x < xmax; x += acc)
            {
                float y = G1(x, A, B, C, D, E, F, -1f);
                if (IsNumber(y))
                {
                    xmin = x;
                    break;
                }
            }

            // Find the largest X coordinate with a real value.
            for (float x = xmax; x > xmin; x -= acc)
            {
                float y = G1(x, A, B, C, D, E, F, -1f);
                if (IsNumber(y))
                {
                    xmax = x;
                    break;
                }
            }

            // Get points for the negative root on the left.
            List<PointF> ln_points = new List<PointF>();
            float xmid1 = xmax;
            for (float x = xmin; x < xmax; x += acc)
            {
                float y = G1(x, A, B, C, D, E, F, -1f);
                if (!IsNumber(y))
                {
                    xmid1 = x - acc;
                    break;
                }
                ln_points.Add(new PointF(picGraph.ClientSize.Width / 2 + xcent + x / scale, picGraph.ClientSize.Height / 2  - ycent - y / scale));
            }

            // Get points for the positive root on the left.
            List<PointF> lp_points = new List<PointF>();
            for (float x = xmid1; x >= xmin; x -= acc)
            {
                float y = G1(x, A, B, C, D, E, F, +1f);
                if (IsNumber(y)) lp_points.Add(new PointF(picGraph.ClientSize.Width / 2 + xcent + x / scale, picGraph.ClientSize.Height / 2 - ycent - y / scale));
            }

            // Make the curves on the right if needed.
            List<PointF> rp_points = new List<PointF>();
            List<PointF> rn_points = new List<PointF>();
            float xmid2 = xmax;
            if (xmid1 < xmax)
            {
                // Get points for the positive root on the right.
                for (float x = xmax; x > xmid1; x -= acc)
                {
                    float y = G1(x, A, B, C, D, E, F, +1f);
                    if (!IsNumber(y))
                    {
                        xmid2 = x + acc;
                        break;
                    }
                    rp_points.Add(new PointF(picGraph.ClientSize.Width / 2 + xcent + x / scale, picGraph.ClientSize.Height / 2 - ycent - y / scale));
                }

                // Get points for the negative root on the right.
                for (float x = xmid2; x <= xmax; x += acc)
                {
                    float y = G1(x, A, B, C, D, E, F, -1f);
                    if (IsNumber(y)) rn_points.Add(new PointF(picGraph.ClientSize.Width / 2 + xcent + x / scale, picGraph.ClientSize.Height / 2 - ycent - y / scale));
                }
            }

            // Connect curves if appropriate.
            // Connect the left curves on the left.
            if (xmin > -edge && ln_points.Count > 0) lp_points.Add(ln_points[0]);

            // Connect the left curves on the right.
            if (xmid1 < edge && lp_points.Count > 0) ln_points.Add(lp_points[0]);

            // Make sure we have the right curves.
            if (rp_points.Count > 0)
            {
                // Connect the right curves on the left.
                rp_points.Add(rn_points[0]);

                // Connect the right curves on the right.
                if (xmax < picGraph.ClientSize.Width / 2 - xcent) rn_points.Add(rp_points[0]);
            }

            // Draw the curves.
            using (Pen thick_pen = new Pen(Color.Red, 2))
            {
                thick_pen.Color = Color.Red;
                if (ln_points.Count > 1)
                    gr.DrawLines(thick_pen, ln_points.ToArray());

                thick_pen.Color = Color.Green;
                if (lp_points.Count > 1)
                    gr.DrawLines(thick_pen, lp_points.ToArray());

                thick_pen.Color = Color.Blue;
                if (rp_points.Count > 1)
                    gr.DrawLines(thick_pen, rp_points.ToArray());

                thick_pen.Color = Color.Orange;
                if (rn_points.Count > 1)
                    gr.DrawLines(thick_pen, rn_points.ToArray());
            }
        }

        // Calculate G1(x).
        // root_sign is -1 or 1.
        private float G1(float x, float A, float B, float C, float D, float E, float F, float root_sign)
        {
            float result = B * x + E;
            result = result * result;
            result = result - 4 * C * (A * x * x + D * x + F);
            result = root_sign * (float)Math.Sqrt(result);
            result = -(B * x + E) + result;
            result = result / 2 / C;

            return result;
        }

        private float countConic (float x, float y, float A, float B, float C, float D, float E, float F)
        {
            return A * x * x + B * x * y + C * y * y + D * x + E * y + F;
        }

        private float countY(float m, float x, float k)
        {
            return m * x + k;
        }

        private void findTangent(object sender, EventArgs e)
        {
            findTangent();
        }

        private void findTangent()
        {
            drln = true;
            float edge = picGraph.ClientSize.Width / 2 * scale;
            float a1, b1, c1, a2, b2, c2, a3, b3, c3, d3, e3, f3, a4, b4, c4;

            lp1.Clear(); lp2.Clear(); mp1.Clear(); mp2.Clear();

            if (coor.Text.Trim() != "" && cekCoor.Checked)
            {
                try
                {
                    x1 = float.Parse(coor.Text.Split(',')[0].Trim());
                    y1 = float.Parse(coor.Text.Split(',')[1].Trim());
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error reading coordinate.\n" + ex.Message);
                    return;
                }
            }
            if (grad.Text.Trim() != "" && cekGrad.Checked)
            {
                try
                {
                    m = float.Parse(grad.Text.Trim());
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error reading gradien.\n" + ex.Message);
                    return;
                }
            }

            float A, B, C, D, E, F;
            try
            {
                A = float.Parse(txtA.Text);
                B = float.Parse(txtB.Text);
                C = float.Parse(txtC.Text);
                D = float.Parse(txtD.Text);
                E = float.Parse(txtE.Text);
                F = float.Parse(txtF.Text);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error reading parameters.\n" + ex.Message);
                return;
            }

            float y = countConic(x1, y1, A, B, C, D, E, F);

            tangent1.Text = "";
            tangent2.Text = "";

            //Point Tangent
            if (IsNumber(x1) && IsNumber(y1) && IsNumber(y) && coor.Text.Trim() != "" && cekCoor.Checked)
            {
                float m1, m2;

                //Count Variable
                a3 = B * B - 4 * A * C;
                b3 = 4 * C * D - 2 * B * E;
                c3 = 2 * B * D - 4 * A * A * E;
                d3 = E * E - 4 * C * F;
                e3 = 2 * D * E - 4 * B * F;
                f3 = D * D - 4 * A * F;
                a4 = a3 * x1 * x1 - b3 * x1 + d3;
                b4 = e3 + b3 * y1 - c3 * x1 - 2 * a3 * x1 * y1;
                c4 = a3 * y1 * y1 + c3 * y1 + f3;

                //Count m
                float temp = b4 * b4 - 4 * a4 * c4;
                m2 = (float)Math.Sqrt(temp);
                if (!IsNumber(m2)) goto skip;
                m1 = (-b4 + m2) / 2 / a4;
                m2 = (-b4 - m2) / 2 / a4;

                //Create point
                lp1.Add(new PointF(0, picGraph.ClientSize.Height / 2 - ycent - countY(m1, -edge - xcent * scale, y1 - m1 * x1) / scale));
                lp1.Add(new PointF(picGraph.Width, picGraph.ClientSize.Height / 2 - ycent - countY(m1, edge - xcent * scale, y1 - m1 * x1) / scale));
                lp2.Add(new PointF(0, picGraph.ClientSize.Height / 2 - ycent - countY(m2, -edge - xcent * scale, y1 - m2 * x1) / scale));
                lp2.Add(new PointF(picGraph.Width, picGraph.ClientSize.Height / 2 - ycent - countY(m2, edge - xcent * scale, y1 - m2 * x1) / scale));

                tangent1.Text = String.Format("y = (-{0} + sqrt({1:0.##})) / (2*{2})*(x-{3}) + {4}\ny = (-{0} - sqrt({1:0.##})) / (2*{2})*(x-{3}) + {4}", b4, temp, a4, x1, y1);

                goto pass;
                skip:;
                tangent1.Text = "Tidak terdapat garis singgung";
                pass:;
            }

            if (IsNumber(m) && grad.Text.Trim() != "" && cekGrad.Checked)
            {
                a1 = A + B * m + C * m * m;
                b1 = B + 2 * C * m;
                c1 = D + E * m;
                a2 = b1 * b1 - 4 * a1 * C;
                b2 = 2 * b1 * c1 - 4 * a1 * E;
                c2 = c1 * c1 - 4 * a1 * F;
                float k1, k2, temp = b2 * b2 - 4 * a2 * c2;
                k2 = (float)Math.Sqrt(temp);
                if (!IsNumber(k2)) goto skip;
                k1 = (-b2 + k2) / 2 / a2;
                k2 = (-b2 - k2) / 2 / a2;
                mp1.Add(new PointF(0, picGraph.ClientSize.Height / 2 - ycent - countY(m, -edge - xcent * scale, k1) / scale));
                mp1.Add(new PointF(picGraph.Width, picGraph.ClientSize.Height / 2 - ycent - countY(m, edge - xcent * scale, k1) / scale));
                mp2.Add(new PointF(0, picGraph.ClientSize.Height / 2 - ycent - countY(m, -edge - xcent * scale, k2) / scale));
                mp2.Add(new PointF(picGraph.Width, picGraph.ClientSize.Height / 2 - ycent - countY(m, edge - xcent * scale, k2) / scale));

                tangent2.Text = String.Format("y = {0}*x - ({1} + sqrt({2:0.##})) / (2*{3})\ny = {0}*x - ({1} - sqrt({2:0.##})) / (2*{3})", m, b2, temp, a2);

                goto pass;
                skip:;
                tangent2.Text = "Tidak terdapat garis singgung";
                pass:;
            }

            if (!cekCoor.Checked) { lp1.Clear(); lp2.Clear(); }
            if (!cekGrad.Checked) { mp1.Clear(); mp2.Clear(); }

            DrawGraph();
        }

        private void clientScroll(object sender, MouseEventArgs e)
        {
            if (e.Delta > 0) scale /= 1.05f;
            else scale *= 1.05f;
            findTangent();
            DrawGraph();
        }

        private void clientDown(object sender, MouseEventArgs e)
        {
            clickIn = true;
            fx = Cursor.Position.X;
            fy = Cursor.Position.Y;
        }

        private void clientUp(object sender, MouseEventArgs e)
        {
            clickIn = false;
            lx = xcent;
            ly = ycent;
        }

        // Return true if the number is not infinity or NaN.
        private bool IsNumber(float number)
        {
            return !(float.IsNaN(number) || float.IsInfinity(number));
        }

        private void reSize(object sender, EventArgs e)
        {
            picGraph.Width = this.Width - 228; picGraph.Height = this.Height - 63;

            if (change() && drawed)
            {
                if (cekCoor.Checked || cekGrad.Checked) findTangent();
                DrawGraph();
            }

            lastWidth = picGraph.Width; lastHeight = picGraph.Height;

            if (clickIn)
            {
                xcent = lx + Cursor.Position.X - fx;
                ycent = ly + fy - Cursor.Position.Y;
                if (cekCoor.Checked || cekGrad.Checked) findTangent();
                DrawGraph();
            }

            if (coor.Text.Trim() + grad.Text.Trim() == "")
            {
                drln = false;
            }

            if (!cekCoor.Checked) { lp1.Clear(); lp2.Clear(); }
            if (!cekGrad.Checked) { mp1.Clear(); mp2.Clear(); }
        }

        private bool change ()
        {
            return (lastWidth != picGraph.Width || lastHeight != picGraph.Height);
        }
    }
}
