namespace CDB
{
    
    public enum packageSize { small, medium, big, adjust }
    public enum packageCategory { Diodes, Transistor, SingleRow, DualRow, QuadRow, Resistors, Void }
    public enum packageType
    {
        DO, SMD, SOD, MELF,
        SMT, SOT, TH, TO92, TO126, SOT23, SOT223, SOT89, TO, TO252, TO263, TO220, DPAK, DDPAK,
        SIP,
        DIP, SO, SOIC, SOP, SSOP, TSOP, TSSOP, ZIP,
        QFN, QFP,
        AXIAL,
        UNKNOW, GENERIC
    }
    public static class packageCollection
    {
        public enum Diodes { DO, SMD, SOD, MELF };
        public enum Transistors { SMT, SOT, TH, TO92, TO126, SOT23, SOT223, SOT89, TO, TO252, TO263, TO220, DPAK, DDPAK };
        public enum SingleRow { SIP };
        public enum DualRow { DIP, SO, SOIC, SOP, SSOP, TSOP, TSSOP, ZIP };
        public enum QuadRow { QFN, QFP };
        public enum Resistors { SMD, AXIAL, MELF };
        public enum Generic { UNKNOW, GENERIC };
    }

    public class Capsula
    {
        public Capsula() : this(packageType.GENERIC, 0, packageSize.medium) { }
        public Capsula(Capsula sample) : this(sample.Type, sample.Pins, sample.Size) { }
        public Capsula(packageType type, int pins, packageSize size = packageSize.medium)
        {
            this.Type = type;
            this.Pins = pins;
            this.Size = size;
        }

        public packageSize Size { get; set; }
        public packageType Type { get; set; }
        public int Pins { get; set; }
        

    }
}
