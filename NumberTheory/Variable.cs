namespace CAM
{
  using System;
  using System . Collections . Generic;
  using System . Linq;
  using System . Text;
  using System . Threading . Tasks;

  public class Variable : Atom
  {
    public static string [ ] Name = new string [ ] { "X", "Y", "B", "I", "J", "K", "M", "O" };
    public string Value { get; set; } = string.Empty;
    
    public Variable(string Label)
    {
      this.Name = new string[]{Label};
      this.Value = Label;
    }
  }
}
