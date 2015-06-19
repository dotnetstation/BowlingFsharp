namespace Bowling.Tests

open NUnit.Framework
open FsUnit
open Bowling.Code

[<TestFixture>]
type ``Given a scoreList`` ()=
    
    [<Test>] member test.
     ``when scoreList is 0 score should be 0`` ()=
            score [0;0;0;0;0;0;0;0;0;0;0;0;0;0;0;0;0;0;0;0] |> should equal 0
 
    [<Test>] member test.
     ``when scoreList all is 1 score should be 20`` ()=
            score [1;1;1;1;1;1;1;1;1;1;1;1;1;1;1;1;1;1;1;1] |> should equal 20
            
    [<Test>] member test.
     ``when scoreList one strike score should be 16`` ()=
            score [10;1;2;0;0;0;0;0;0;0;0;0;0;0;0;0;0;0;0] |> should equal 16
            
    [<Test>] member test.
     ``when scoreList two strike score should be 36`` ()=
            score [10;1;2;10;3;2;0;0;0;0;0;0;0;0;0;0;0;0] |> should equal 36
                        
    [<Test>] member test.
     ``when scoreList two strike score should be 38`` ()=
            score [10;10;2;1;0;0;0;0;0;0;0;0;0;0;0;0;0;0] |> should equal 38
                        
    [<Test>] member test.
     ``when scoreList one strike at the end score should be 18`` ()=
            score [0;0;0;0;0;0;0;0;0;0;0;0;0;0;0;0;0;0;10;3;5] |> should equal 18

    [<Test>] member test.
     ``when scoreList one spare score should be 15`` ()=
            score [4;6;1;3;0;0;0;0;0;0;0;0;0;0;0;0;0;0;0;0] |> should equal 15
            
    [<Test>] member test.
     ``when scoreList one spare at the end score should be 13`` ()=
            score [0;0;0;0;0;0;0;0;0;0;0;0;0;0;0;0;0;0;4;6;3] |> should equal 13