﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Security.Cryptography;
using System.Text;

public class PasswordHash
{
    private string passwd;
    private string passkey;

<<<<<<< HEAD
=======

>>>>>>> SCCC ITC172 - .NET
    public Byte[] HashIt(string password, string passkey)
    {
        this.passwd = password;
        this.passkey = passkey;


        //Byte arrays to store the bytes for the password
        Byte[] originalBytes;
        Byte[] encodedBytes;
        //use a modern method to hash
        SHA512 shaHash = SHA512.Create();


        //combine the passkey and the password
        string passToHash = passkey + passwd;


        //convert the string to bytes
        originalBytes = ASCIIEncoding.Default.GetBytes(passToHash);
        //take the converted string and hash it
        encodedBytes = shaHash.ComputeHash(originalBytes);


        //return the hashed password
        return encodedBytes;
    }
}