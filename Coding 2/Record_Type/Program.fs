open System

type Student =
        {
           Name : string;
           Credits : int;
           GPA : double;
        }

let record = {Name = "Jones"; Credits = 109; GPA = 3.85 }


printfn "Student: %A %A %A" record.Name record.Credits record.GPA
