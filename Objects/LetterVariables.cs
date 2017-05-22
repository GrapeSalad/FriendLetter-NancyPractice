namespace FriendLetter.Objects
{
  public class LetterVariables
  {
    private string _recipient;
    private string _sender;

    public void Setperson(string newRecipient)
    {
      _recipient = newRecipient;
    }

    public string Getperson()
    {
      return _recipient;
    }

    public string GetSender()
    {
      return _sender;
    }

    public void SetSender(string newSender)
    {
      _sender = newSender;
    }

  }
}
