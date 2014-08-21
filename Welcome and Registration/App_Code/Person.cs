using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

public class Person
{
    public string lastName { set; get; }
    public string firstName { set; get; }
    public string email { set; get; }
    public string password { set; get; }
    public Byte[] passkey { set; get; }
    public object hashedpass { get; set; }
}
