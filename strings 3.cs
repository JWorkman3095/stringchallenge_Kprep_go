using System;

string[] randomStrings = {
    "KCKMjm1q4ClTkKIm3RGZ",
    "6tTkOZI346hSVyzopihn",
    "4SR5KUmB9qa5uA5gn2vv",
    "CIlitpzKlfpXf8eupwRl",
    "BKNOBaetlnYw0fnJtzw5",
    "Cb7PNe2AEDyeeMwFQYJ8",
    "k1TcQCIboMOKkcRNLlKG",
    "9L4HFK5pkVHyj1iIo8ZK",
    "R7lqTHL52LhiJJ5sDOj7",
    "v8vQirbT5ZCS54WtQ60m",
    "r7uu6zPaeJN0WIaJKKlR",
    "hyd8ZQn1KDG313Gs9kG8",
    "zrux2JoRWjwSHout2ATs",
    "wE7G0gfcIgpDVoPF9Fe4",
    "maDsDqIrVlfN3lbF1cBl",
    "A3p4A5evIIMBiayRYbYf",
    "4M8dv31fSiRhFciCpeJJ",
    "55KSkCWg4xhhtdEs6rPY",
    "6iOicdqGWi6kP5wMXm4Z",
    "QLzfPgWL4PGCOrOaRG09",
    "k68V0RnDF3NOETCyn3DD",
    "zFy1nBUO0CqtuPUaYx1u",
    "kCeVu4voc84T5yExWQMM",
    "EQ2jWgYAagGDawHRf11m",
    "HuwAX0ENxoAkkZMdMat1",
    "5TAAWwO4A4qKCwak2e4r",
    "bUm6ho2m33s7pNcFpEJK",
    "EQldy8TdCNl7SXcb32bU",
    "OrXZVLSLOE1J5Z31bpwD",
    "jwyOANUf35TatQtEgoyO",
    "FKgYnfxTOq2UhQ3YMKAV",
    "YpS3bc4LPeOqiQ6jiiYB",
    "mfgFNelXhLCPA7fjnpba",
    "KndUYncIksi2mtfVbTtR",
    "pOB3HE9DGKnM80mY4Bw5",
    "z0h1FZXSiAUxlsuLPpmA",
    "f186JA3KD5wKwmJXuNul",
    "kJ5UMLzbyCEoiGFg24cE",
    "H45Aejd7AyEfLG4LenjQ",
    "jfdfWmpKwfY9W9DQTiAH",
    "8xV6SgGFnYFvtN2CTKDN",
    "WEHgJ838cK9CcAGI7IQp",
    "RcjCRlrp0Dws9FbbU1bC",
    "ZXCmBS6KM7KeRuDzqeK2",
    "GBQUzKtKIWgzxHxpypL4",
    "9xVgNTUoQoUNJF52hqYw",
    "6InjKmHZUJcoc1iOSvGf",
    "LUJHcl8DSuLiwn5U4mYC",
    "10YFGJ4xSFpSWiGGMKlt",
    "bQ7Txv5mNIWlkdkNrnrT"
};
var count = 0;
foreach(var s in randomStrings) {
    if (s.Contains("3")) {
        count++;
        Console.WriteLine(s);
    }
}
Console.WriteLine($"There are {count} strings containing a 3");

