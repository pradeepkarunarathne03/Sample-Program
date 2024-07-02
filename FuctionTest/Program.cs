


using FuctionTest;

DataAccess myObject = new DataAccess();





int a = myObject.Calculate(5, 10);
Console.WriteLine(a);



TechAllo saveTechnician = new TechAllo();
saveTechnician.Id = 10;
saveTechnician.JobCardNumber = "AC010205F005";
saveTechnician.TechnicianName = "Kamal";

ContMst newContact = new ContMst
{
    JobCardNumber = "AC010205F005",
    Id = 10,
    ContractNumber = "AC/P/010205F005",

};


List<AcSche> dataGridView_1 = new List<AcSche>
{

};

List<AcSche> saveSchedule = new List<AcSche>();

foreach (var item in dataGridView_1)
{
    AcSche newSchedule = new AcSche();
    newSchedule.Id = item.Id;
    newSchedule.JobCardNumber = item.JobCardNumber;
    newSchedule.ContractNumber = item.ContractNumber;
    newSchedule.ScheduleDate = item.ScheduleDate;

    saveSchedule.Add(newSchedule);

}



myObject.CreateAcShedule(saveTechnician,newContact,saveSchedule);


double result = myObject.CalculateSquare(5, 10);

Console.WriteLine(result);



