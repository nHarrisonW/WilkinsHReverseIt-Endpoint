//N. Harrison Wilkins
//10-26-2022
//REVERSE IT - ENDPOINTS
//THIS CONTROLLER ALLOWS THE USER TO INPUT INFORMATION VIA THE URL, THEN THE INFORMATION THAT THEY ENTER IS REPEATED TO THEM IN REVERSE,  FEATURES DATA VALIDATION ALTHOUGH IT STILL REVERSES STRINGS, PRESENTING A DIFFERENT PROMPT
//PEER REVIEW BY : John Magpantay   notes : Code works well, data validation was there! I like how its unique, You put the number and the the number is already outputed reversed, Clean code and goodjob overall!


using Microsoft.AspNetCore.Mvc;

namespace WilkinsHReverseIt_Endpoint.Controllers;

[ApiController]
[Route("[controller]")]
public class ReverseController : ControllerBase
{
    [HttpGet]
    [Route ("this/{reversible}")]

    public string ReverseThisNumber(string reversible, bool isNumber, int number = 0, int reverseNumber = 0)
    {
        isNumber = Int32.TryParse(reversible, out number);
            string rvrs = string.Empty;
        if(isNumber == true)
        {
            for(int i = reversible.Length - 1; i >= 0; i--)
            {
                rvrs += reversible[i];
            }
                return $"{rvrs} is the number you entered, but backwards!";
        }else if(!isNumber)
        {
            for(int i = reversible.Length - 1; i >= 0; i--)
            {
                rvrs += reversible[i];

            }

        }
            return $"{rvrs} is what you entered, but backwards, although it wasn't exactly a number...";
    }
                
}
