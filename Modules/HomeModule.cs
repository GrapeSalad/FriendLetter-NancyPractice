using Nancy;
using FriendLetter.Objects;

namespace nancy
{
  public class HomeModule : NancyModule
  {
    public HomeModule()
    {

      Get["/"] = _ =>  {
        LetterVariables myLetterVariables = new LetterVariables();
        myLetterVariables.Setperson("Kimlan");
        myLetterVariables.SetSender("David");

        return View["hello.cshtml", myLetterVariables];
      };
      Get["/form"] = _ => View["form.cshtml"];
      Get["/greeting_card"] = _ => {
        LetterVariables myLetterVariables = new LetterVariables();
        myLetterVariables.Setperson(Request.Query["recipient"]);
        myLetterVariables.SetSender(Request.Query["sender"]);
        return View["hello.cshtml", myLetterVariables];
      };
      Get["/favorite_photos"] = _ => View["favorite_photos.html"];
    }
  }
}
