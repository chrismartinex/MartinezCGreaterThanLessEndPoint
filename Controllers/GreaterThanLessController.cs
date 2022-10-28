//Chris Martinez
//10/25/22
//Greater Than Less than - EndPoint Challenge
//https://localhost:****/GreaterThanLess/compare/{number1}/{number2}
//peer review: Jessie Lamzon
//Code is working well and without any errors. It is done with assignment requirement.  Good Job!


using Microsoft.AspNetCore.Mvc;

namespace MartinezCGreaterThanLessEndPoint.Controllers;

[ApiController]
[Route("[controller]")]
public class GreaterThanLessController : ControllerBase
{
 public string hello(){
  return "hello";
 }

 [HttpGet]
 [Route("compare/{number1}/{number2}")]

 public string Math( string number1, string number2)
 {
  string ans = "";
  int convertNum1 = Convert.ToInt32(number1);
  int convertNum2 = Convert.ToInt32(number2);
  if (convertNum1 == convertNum2)
  {
   ans = $"{convertNum1} is equal {convertNum2}";
  }else if(convertNum1 < convertNum2)
  {
   ans = $"{convertNum1} less than {convertNum2}";
  }else
  {
   ans = $"{convertNum1} greater than {convertNum2}";
  }

  return ans;

 }

}
