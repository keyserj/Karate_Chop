module BinarySearcher

let search (array : int[]) x =
    let rec binarySearch first last =
        if first > last then
            -1
        else
            let middle = (first + last) / 2
            match (compare x array.[middle]) with
            | 0 -> middle
            | -1 -> binarySearch first (middle - 1)
            | 1 -> binarySearch (middle + 1) last
            | _ -> failwith "middle wasn't <,=,or > target"
    binarySearch 0 (array.Length - 1)