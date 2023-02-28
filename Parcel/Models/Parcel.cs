using System.Collections.Generic;

namespace Parcel.Model
{
  public class Parcels
  {
    public float Length {get;set;}
    public float Width {get;set;}
    public float Height {get;set;}
    public float Weight {get;set;}
    private static List<Parcels> _instances = new List<Parcels> {};

    public Parcels(string height, string width, string length, string weight)
    {
      Length = Parse(length);
      Height = Parse(height);
      Width = Parse(width);
      Weight = Parse(weight);
      _instances.Add(this);
    }
  }
}