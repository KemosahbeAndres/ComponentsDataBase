namespace CDB
{
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
}
