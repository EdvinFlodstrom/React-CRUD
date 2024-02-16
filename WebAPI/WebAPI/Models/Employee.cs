using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

public class Employee
{
    [Key]
    public int EmployeeId { get; set; }
    public string EmployeeName { get; set; }
    public string Department {  get; set; }
    public string EmailId {  get; set; }
    public DateTime DOJ {  get; set; }
}