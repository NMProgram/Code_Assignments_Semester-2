class Doctor
{
    public static int CARDoctors = 1, NEUDoctors = 1, ONCDoctors = 1, OTHDoctors = 1;
    public readonly string Id;
    public string Name, Department;
    public readonly List<Patient> AssignedPatients;
    public readonly List<Doctor> Supervisees;
    public string SupervisorId;
    public const string DefaultSupervisorId = "-";
    public Doctor(string name, string department)
    {
        int doctorCount;
        doctorCount = department switch
        {
            "Cardiology" => CARDoctors++,
            "Neurology" => NEUDoctors++,
            "Oncology" => ONCDoctors++,
            _ => -1,
        };
        if (doctorCount == -1) { department = "Other"; doctorCount = OTHDoctors++; }
        // Instance args
        Name = name;
        Department = department;
        AssignedPatients = [];
        Supervisees = [];
        SupervisorId = DefaultSupervisorId;
        // Id Generation
        string acronym = department[..3].ToUpper();
        Id = doctorCount switch
        {
            < 10 => acronym + "00" + doctorCount,
            >= 10 and < 100 => acronym + "0" + doctorCount,
            >= 100 => acronym + doctorCount,
        };
    }
}
