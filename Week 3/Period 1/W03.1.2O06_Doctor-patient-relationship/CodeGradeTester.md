# Overview
This exercise requires the programmer to create three classes (`Patient`, `Doctor`, `Hospital`) that are relationally connected to eachother.
The Hospital class hosts a `List<Doctor>` and a `List<Patient>` field that it monitors with methods like `AddPatient(Patient)` and `RemoveDoctor(string id)`.
The Doctor class also has a `List<Doctor>` field for supervisees over the doctor instance 
and a `List<Patient>` field for all of the Patient instances assigned to this Doctor instance.

Only the three classes were coded by me, the rest was provided as a template by CodeGrade.

This one was by far the most difficult and annoying exercise yet. 
To start off, the class diagram that you were meant to use didn't even include a way to keep track of the total amount of patients and doctors, 
making it virtually impossible to set the ID to what CodeGrade wanted.
To compensate for this, I had to make completely new fields dedicated to doing that, which I think is kinda stupid. 
If you're giving the programmer a class diagram to follow, don't expect them to make any more fields than what is asked.

Second of all, the whole relationship premise of these classes could have easily just been done with files or databases, 
but because we don't know how to do that yet in `C#`, you have to do it with several `foreach` loops that really are unnecessary.

And lastly, CodeGrade also wanted a very specific order to how error messages are printed, with barely any guidance on what that order was supposed to be.
That means that you had to practically figure it out through trial and error, which is absolutely ridiculous.

So yeah, this one sucked balls and took me about 8-10 hours. Not fun.

# Code
For the different classes and the CodeGrade test files, see the other .cs files in this directory.
```cs
static class CodeGradeTester
{
    static void Main(string[] args)
    {
        // TestRemoveDoctor();
        switch (args[1])
        {
            case "ReadOnly": TestReadOnly(); return;
            case "Constant": TestConstant(); return;
            case "Static": TestStatic(); return;
            case "PatientID": TestPatientId(); return;
            case "DoctorID": TestDoctorId(Convert.ToInt32(args[2])); return;
            case "Hospital": TestHospital(); return;
            case "RemovePatient": TestRemovePatient(); return;
            case "RemoveDoctor": TestRemoveDoctor(); return;
            default: throw new ArgumentOutOfRangeException($"{args[1]}", $"Unexpected args value: {args[1]}");
        };
    }

    public static void TestReadOnly()
    {
        Console.WriteLine("=== Patient ===");
        Type clsType = typeof(Patient);
        TestUtils.PrintIsReadOnlyField(clsType, "Id");

        Console.WriteLine("\n=== Doctor ===");
        clsType = typeof(Doctor);
        TestUtils.PrintIsReadOnlyField(clsType, "Id");
        TestUtils.PrintIsReadOnlyField(clsType, "AssignedPatients");
        TestUtils.PrintIsReadOnlyField(clsType, "Supervisees");

        Console.WriteLine("\n=== Hospital ===");
        clsType = typeof(Hospital);
        TestUtils.PrintIsReadOnlyField(clsType, "Doctors");
        TestUtils.PrintIsReadOnlyField(clsType, "UnassignedPatients");
        TestUtils.PrintIsReadOnlyField(clsType, "Departments");
    }

    public static void TestConstant()
    {
        TestUtils.PrintIsConstantField(typeof(Doctor), "DefaultSupervisorId");
        TestUtils.PrintIsConstantField(typeof(Hospital), "Name");
    }

    public static void TestStatic()
    {
        TestUtils.PrintIsStaticClass(typeof(Hospital));
    }

    public static void TestPatientId()
    {
        List<Patient> patients = [];
        for (int i = 0; i < 100; i++)
        {
            patients.Add(new Patient("John Doe", 25));
        }

        Console.WriteLine($"Patient ID of patient #1: {patients[0].Id}");
        Console.WriteLine($"Patient ID of patient #5: {patients[4].Id}");
        Console.WriteLine($"Patient ID of patient #10: {patients[9].Id}");
        Console.WriteLine($"Patient ID of patient #100: {patients[99].Id}");
    }

    public static void TestDoctorId(int seed)
    {
        Random rand = new(seed);
        List<string> departments = [];
        departments.AddRange(Hospital.Departments);
        departments.Add("Anesthetics");

        List<Doctor> doctors = [];
        for (int i = 0; i < 999; i++)
        {
            doctors.Add(new("John Doe", departments[rand.Next(0, departments.Count)]));
        }
        for (int i = doctors.Count - 5; i < doctors.Count; i++)
        {
            Console.WriteLine(doctors[i].Id);
        }
    }

    public static void TestHospital()
    {
        Console.WriteLine("=== Name ===");
        Console.WriteLine(Hospital.Name);

        Console.WriteLine("\n=== Departments ===");
        foreach (string department in Hospital.Departments)
        {
            Console.WriteLine(department);
        }

        Console.WriteLine("\n=== Adding doctors and patients ===");
        Doctor doctor = new("Harleen Quinzel", "Psychiatry");
        Hospital.AddDoctor(doctor);
        Doctor lastAddedDoctor = Hospital.Doctors[^1]; // Take last doctor in list (the one that was just added)
        Console.WriteLine($"Doctor's name: {lastAddedDoctor.Name}");
        Console.WriteLine("\nAdding doctor again");
        Hospital.AddDoctor(doctor);

        Console.WriteLine();
        Patient patient = new("Joseph Kerr", 44);
        Hospital.AddPatient(patient);
        Patient lastAddedPatient = Hospital.UnassignedPatients[^1];
        Console.WriteLine($"Patient's name: {lastAddedPatient.Name}");
        
        Console.WriteLine("\nAdding patient again");
        Hospital.AddPatient(patient);

        Console.WriteLine("\n=== Assigning doctors to patients ===");
        List<Patient> patients = [
            new("Pamela Lillian Isley", 28),
            new("Harvey Dent", 26),
            new("Jonathan Crane", 35),
            new("Edward Nygma", 37),
        ];

        Console.WriteLine("Attemping to assign to a non-existing doctor...");
        foreach (var pat in patients)
        {
            Hospital.AssignDoctorToPatient(doctor.Id, pat.Id);
        }

        Hospital.AddDoctor(doctor);
        Console.WriteLine("\nAttempting to add non-registered patients...");
        foreach (var pat in patients)
        {
            Hospital.AssignDoctorToPatient(doctor.Id, patient.Id);
        }

        Console.WriteLine("\nAdding and assigning patients...");
        foreach (var pat in patients)
        {
            Hospital.AddPatient(pat);
            Hospital.AssignDoctorToPatient(doctor.Id, pat.Id);
        }

        Console.WriteLine("\nAttempting to add the patients to the same doctor...");
        foreach (var pat in patients)
        {
            Hospital.AssignDoctorToPatient(doctor.Id, pat.Id);
        }

        Console.WriteLine();
        Doctor anotherDoc = new("Thomas Alan Wayne", "Misc");
        Hospital.AddDoctor(anotherDoc);
        Console.WriteLine("Attempting to assign already assigned patient to another doctor...");
        foreach (var pat in patients)
        {
            Hospital.AssignDoctorToPatient(anotherDoc.Id, pat.Id);
        }

        Console.WriteLine("\nAttempting to assign patients to doctors when either or both don't exist...");
        Hospital.AssignDoctorToPatient(anotherDoc.Id, "PAT---");
        Console.WriteLine();
        Hospital.AssignDoctorToPatient("CAR---", patient.Id);
        Console.WriteLine();
        Hospital.AssignDoctorToPatient("CAR---", "PAT---");

        Console.WriteLine("\nAssigning supervisees to supervisor...");
        Console.WriteLine($"{doctor.Name} has {doctor.Supervisees.Count} supervisees");

        Doctor yetAnotherDoc = new("Leslie Maurin Thompkins", "Emergency");
        Hospital.AddDoctor(yetAnotherDoc);
        Hospital.AssignSuperviseeToSupervisor(anotherDoc.Id, doctor.Id);
        Hospital.AssignSuperviseeToSupervisor(yetAnotherDoc.Id, doctor.Id);

        Console.WriteLine($"{doctor.Name} has {doctor.Supervisees.Count} supervisees:");
        foreach (var supervisee in doctor.Supervisees)
        {
            Console.WriteLine($" - {supervisee.Name}");
        }

        Console.WriteLine("\nAttempting to assign supervisees to supervisors when either or both don't exist...");
        Hospital.AssignSuperviseeToSupervisor(yetAnotherDoc.Id, "NEU---");
        Hospital.AssignSuperviseeToSupervisor("CAR---", doctor.Id);
        Hospital.AssignSuperviseeToSupervisor("CAR---", "NEU---");

        Console.WriteLine($"\n{anotherDoc.Name}'s supervisor ID: {anotherDoc.SupervisorId}");
        Console.WriteLine($"{yetAnotherDoc.Name}'s supervisor ID: {yetAnotherDoc.SupervisorId}");
    }

    public static void TestRemovePatient()
    {
        List<Patient> patients = [
            new("Jackie Chan", 31),
            new("Viggo Mortensen", 44),
            new("Sylverster Stallone", 34),
        ];

        foreach (Patient pat in patients)
        {
            Hospital.AddPatient(pat);
        }

        Patient lastAddedPatient = Hospital.UnassignedPatients[^1];
        Console.WriteLine($"\nLast patient's name: {lastAddedPatient.Name}");

        Hospital.RemovePatient(lastAddedPatient.Id);
        lastAddedPatient = Hospital.UnassignedPatients[^1]; 
        Console.WriteLine($"Last patient's name: {lastAddedPatient.Name}");
    }

    public static void TestRemoveDoctor()
    {
        Doctor doctor = new("Charley Dixon", "Surgery");
        Hospital.AddDoctor(doctor);

        List<Patient> patients = [
            new("John Connor", 44),
            new("Sarah J. Connor", 19),
            new("Kyle Reese", 26),
        ];

        foreach (var patient in patients)
        {
            Hospital.AddPatient(patient);
            Hospital.AssignDoctorToPatient(doctor.Id, patient.Id);
        }

        Console.WriteLine($"\nDr. {doctor.Name}'s assigned patients:");
        foreach (var patient in doctor.AssignedPatients)
        {
            Console.WriteLine($" - Patient ID: {patient.Id}");
        }

        Doctor anotherDoc = new("Peter Silberman", "Psychiatry");
        Doctor yetAnotherDoc = new("Boyd Sherman", "Psychology");
        Hospital.AddDoctor(anotherDoc);
        Hospital.AddDoctor(yetAnotherDoc);

        Hospital.AssignSuperviseeToSupervisor(anotherDoc.Id, doctor.Id);
        Hospital.AssignSuperviseeToSupervisor(yetAnotherDoc.Id, doctor.Id);

        foreach (var supervisee in doctor.Supervisees)
        {
            Console.WriteLine($"{supervisee.Name}'s supervisor: {supervisee.SupervisorId}");
        }

        Console.WriteLine("\nRemoving doctor/supervisee from the hospital...");
        Hospital.RemoveDoctor(yetAnotherDoc.Id);
        foreach (var supervisee in doctor.Supervisees)
        {
            Console.WriteLine($"{supervisee.Name}'s supervisor: {supervisee.SupervisorId}");
        }

        Console.WriteLine("\nRemoving doctor/supervisor from the hospital...");
        Hospital.RemoveDoctor(doctor.Id);

        Console.WriteLine($"\nLast {patients.Count} unassigned patients:");
        for (int i = patients.Count; i > 0; i--)
        {
            Console.WriteLine($" - Patient ID: {Hospital.UnassignedPatients[^i].Id}");
        }

        foreach (var supervisee in doctor.Supervisees)
        {
            Console.WriteLine($"{supervisee.Name}'s supervisor: {supervisee.SupervisorId}");
        }
    }
}
```
