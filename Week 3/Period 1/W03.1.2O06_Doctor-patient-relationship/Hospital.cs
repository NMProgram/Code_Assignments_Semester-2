static class Hospital
{
    public const string Name = "Erasmus MC";
    public static readonly List<Doctor> Doctors = [];
    public static readonly List<Patient> UnassignedPatients = [];
    public static readonly string[] Departments = ["Cardiology", "Neurology", "Oncology"];
    public static void AddDoctor(Doctor doctor)
    {
        if (Doctors.Contains(doctor)) 
        { Console.WriteLine($"Doctor {doctor.Id} already works in the hospital"); }
        else 
        { Doctors.Add(doctor); Console.WriteLine($"Doctor {doctor.Id} has been added"); }
    }
    public static void RemoveDoctor(string id)
    {
        foreach (Doctor doctor in Doctors)
        {
            if (doctor.Id == id)
            { 
                Doctors.Remove(doctor); 
                foreach (Doctor supervisee in doctor.Supervisees)
                {
                    if (supervisee.SupervisorId == doctor.Id)
                    {
                        supervisee.SupervisorId = "-";
                    }
                }
                Console.WriteLine($"Doctor {id} has been removed"); 
                return;
            }
        }
        Console.WriteLine($"Doctor with ID {id} not found");
    }
    public static void AddPatient(Patient patient)
    {
        if (!UnassignedPatients.Contains(patient)) 
        { 
            UnassignedPatients.Add(patient);
            Console.WriteLine($"Patient {patient.Id} registered in the hospital");
            return;
        }
        Console.WriteLine($"Patient {patient.Id} is already registered in the hospital");
    }
    public static void RemovePatient(string id)
    {
        foreach (Patient patient in UnassignedPatients)
        {
            if (patient.Id == id)
            {
                UnassignedPatients.Remove(patient);
                Console.WriteLine($"Patient {id} has been removed"); 
                return;
            }
        }
        Console.WriteLine($"Patient with ID {id} not found");
    }
    public static void AssignDoctorToPatient(string doctorId, string patientId)
    {
        Doctor? foundDoctor = null;
        Patient? foundPatient = null;
        bool error = false;
        
        foreach (Doctor doctor in Doctors)
        {
            if (doctor.Id == doctorId) 
                { 
                    foundDoctor = doctor;
                }
        }
        if (foundDoctor is null) 
        { 
            Console.WriteLine($"Doctor with ID {doctorId} not found"); 
            error = true; 
        }
        foreach (Doctor doctor in Doctors)
        {
            foreach (Patient patient in doctor.AssignedPatients)
            {
                if (patient.Id == patientId && doctor.Id == doctorId)
                {
                    foundPatient = patient;
                    break;
                }
                else if (patient.Id == patientId)
                {
                    foundPatient = patient;
                    error = true;
                    Console.WriteLine($"Patient with ID {patientId} is already assigned to another doctor");
                    break;
                }
            }
        }
        if (foundPatient is null)
        {
            foreach (Patient patient in UnassignedPatients)
            {
                if (patient.Id == patientId)
                { foundPatient = patient; break; }
            }
        }
        if (foundPatient is null)
        {
            Console.WriteLine($"Patient with ID {patientId} not found");
            return;
        }
        if (foundDoctor is not null)
        {
            if (foundDoctor.AssignedPatients.Contains(foundPatient))
            {
                Console.WriteLine($"Patient with ID {patientId} is already assigned to another doctor");
                return;
            }
            else if (!error)
            {
                foundDoctor.AssignedPatients.Add(foundPatient);
                Console.WriteLine($"Patient {patientId} is assigned to doctor {doctorId}");
            }
        }
    }
    public static void AssignSuperviseeToSupervisor(string superviseeId, string supervisorId)
    {
        Doctor? foundDoctor = null;
        Doctor? foundSupervisee = null;
        foreach (Doctor doctor in Doctors)
        {
            if (doctor.Id == supervisorId) { foundDoctor = doctor; }
            else if (doctor.Id == superviseeId) { foundSupervisee = doctor; }
        }
        List<string> missingDoctors = [];
        if (foundSupervisee is null) { missingDoctors.Add(superviseeId); }
        if (foundDoctor is null) { missingDoctors.Add(supervisorId); }
        if (missingDoctors.Count > 0)
        {
            Console.WriteLine("Doctor(s) not found:");
            foreach (string id in missingDoctors)
            { Console.WriteLine($" - {id}"); }
            return;
        }
        foundSupervisee!.SupervisorId = supervisorId;
        foundDoctor!.Supervisees.Add(foundSupervisee!);
        Console.WriteLine($"Added {superviseeId} to supervisor {supervisorId}");
    }
}
