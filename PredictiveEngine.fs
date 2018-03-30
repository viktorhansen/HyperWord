module HyperWord.PredictiveEngine

open System.IO

let pathToDict = Path.Combine(__SOURCE_DIRECTORY__, "dict.txt")

let loadDictFromPath path = 
    File.ReadAllLines path

let loadDict () = 
    let dict = loadDictFromPath pathToDict
    dict

let sweDict = loadDict()

let autocomplete (prefix:string) (dict:string[]) = 
    let candidates = dict |> Array.filter (fun word -> word.StartsWith(prefix))
    candidates