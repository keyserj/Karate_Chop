module BinarySearcherTests

open Xunit

[<Fact>]
let ``Searching empty list returns not found`` () =
    let actual = BinarySearcher.search [||] 0
    Assert.Equal(-1, actual)

[<Theory>]
[<InlineData(0, -1)>]
[<InlineData(1, 0)>]
[<InlineData(2, -1)>]
let ``Search array of size one`` (target, expected) =
    let actual = BinarySearcher.search [|1|] target
    Assert.Equal(expected, actual)

[<Theory>]
[<InlineData(0, -1)>]
[<InlineData(1, 0)>]
[<InlineData(2, -1)>]
[<InlineData(3, 1)>]
[<InlineData(4, -1)>]
let ``Search array of size two`` (target, expected) =
    let actual = BinarySearcher.search [|1; 3|] target
    Assert.Equal(expected, actual)

[<Theory>]
[<InlineData(0, -1)>]
[<InlineData(1, 0)>]
[<InlineData(2, -1)>]
[<InlineData(3, 1)>]
[<InlineData(4, -1)>]
[<InlineData(5, 2)>]
[<InlineData(6, -1)>]
let ``Search array of size three`` (target, expected) =
    let actual = BinarySearcher.search [|1; 3; 5|] target
    Assert.Equal(expected, actual)

[<Theory>]
[<InlineData(0, -1)>]
[<InlineData(1, 0)>]
[<InlineData(2, -1)>]
[<InlineData(3, 1)>]
[<InlineData(4, -1)>]
[<InlineData(5, 2)>]
[<InlineData(6, -1)>]
[<InlineData(7, 3)>]
[<InlineData(8, -1)>]
let ``Search array of size four`` (target, expected) =
    let actual = BinarySearcher.search [|1; 3; 5; 7|] target
    Assert.Equal(expected, actual)