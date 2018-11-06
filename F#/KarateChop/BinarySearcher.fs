module BinarySearcher

let rec binarySearch (array : int[]) x first last =
    match array with
    | empty when first > last ->
        -1
    | _ ->
        let middle = (first + last) / 2
        match array.[middle] with
        | middleIsEqual when middleIsEqual = x ->
            middle
        | middleIsGreater when middleIsGreater > x ->
            binarySearch array x first (middle - 1)
        | middleIsLesser when middleIsLesser < x ->
            binarySearch array x (middle + 1) last
        | _ -> -1

let search (array : int[]) x =
    binarySearch array x 0 (array.Length - 1)