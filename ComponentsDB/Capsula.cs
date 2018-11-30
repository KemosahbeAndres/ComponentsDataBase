using System.Drawing;

namespace ComponentsViewer
{
    public enum cSize { small, medium, big, adjust }
    public struct packageType
    {
        enum Diodes { DO, SMD, SOD, MELF };
        enum Transistors { SMT, SOT, TH, TO92, TO126, SOT23, SOT223, SOT89, TO, TO252, TO263, TO220, DPAK, DDPAK };
        enum SingleRow { SIP};
        enum DualRow { DIP, SO, SOIC, SOP, SSOP, TSOP, TSSOP, ZIP};
        enum QuadRow { QFN, QFP};
        enum Resistors { SMD, AXIAL, MELF};
    }

    public class Capsula
    {
        public Capsula()
        {
            this.Size = cSize.medium;
        }
        public Capsula(Capsula sample)
        {
            this.Type = sample.Type;
            this.Pins = sample.Pins;
            this.Canvas = sample.Canvas;
            this.Graph = sample.Graph;
            this.Size = sample.Size;
        }
        public Capsula(packageType type, int pins, Rectangle rect, Graphics graph, cSize size = cSize.medium)
        {
            this.Type = type;
            this.Pins = pins;
            this.Canvas = rect;
            this.Graph = graph;
            this.Size = size;

        }
        
        public cSize Size { get; set; }
        public packageType Type { get; set; }
        public Rectangle Canvas { get; set; }
        public Graphics Graph { get; set; }
        public int Pins { get; set; }
        public void Draw()
        {

        }
        public void Draw(Rectangle owner)
        {

        }

        //Attributos & Metodos Privados.
        private Point[] ProcessDraw()
        {
            Point[] points = new Point[50];
            points[0] = new Point(0, 0);
            return points;
        }

    }
}
