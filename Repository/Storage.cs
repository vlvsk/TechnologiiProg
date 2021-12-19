namespace TechnologiiProg.Repository
{
    public class Storage
    {
        public static readonly ClientStorage ClientStorage = new();
        public static readonly DoctorStorage DoctorStorage = new();
        public static readonly RegistryStorage RegistryStorage = new();
        public static readonly TypesRecordsStorage TypesRecordsStorage = new();
        public static readonly DataBaseRecordsStorage DataBaseRecordsStorage = new();
        public static readonly DataBasePaymentsStorage DataBasePaymentsStorage = new();
        public static readonly DataBaseDocumentsStorage DataBaseDocumentsStorage = new();
        public static readonly DataBaseDoctorsScheduleStorage DataBaseDoctorsScheduleStorage = new();
    }
}