namespace SReynolds.Types.Common

open System

type EircodeRoutingKey = A41 | A42 | A45 | A63 | A67 | A75 | A81 | A82 | A83 | A84 | A85 | A86 | A91 | A92 | A94 | A96 | A98 | C15 | D01 | D02 | D03 | D04 | D05 | D06 | D6W | D07 | D08 | D09 | D10 | D11 | D12 | D13 | D14 | D15 | D16 | D17 | D18 | D20 | D22 | D24 | E21 | E25 | E32 | E34 | E41 | E45 | E53 | E91 | F12 | F23 | F26 | F28 | F31 | F35 | F42 | F45 | F52 | F56 | F91 | F92 | F93 | F94 | H12 | H14 | H16 | H18 | H23 | H53 | H54 | H62 | H65 | H71 | H91 | K32 | K34 | K36 | K45 | K56 | K67 | K78 | N37 | N39 | N41 | N91 | P12 | P14 | P17 | P24 | P25 | P31 | P32 | P36 | P43 | P47 | P51 | P56 | P61 | P67 | P72 | P75 | P81 | P85 | R14 | R21 | R32 | R35 | R42 | R45 | R51 | R56 | R93 | R95 | T12 | T23 | T34 | T45 | T56 | V14 | V15 | V23 | V31 | V35 | V42 | V92 | V93 | V94 | V95 | W12 | W23 | W34 | W91 | X35 | X42 | X91 | Y14 | Y21 | Y25 | Y34 | Y35
type UniqueIndentifer = string

type Eircode =
    private
    | Eircode of EircodeRoutingKey * UniqueIndentifer
    static member private isValidRoutingKey(s : string) : EircodeRoutingKey option =
        match s with
        | "A41" -> Some A41
        | "A42" -> Some A42
        | "A45" -> Some A45
        | "A63" -> Some A63
        | "A67" -> Some A67
        | "A75" -> Some A75
        | "A81" -> Some A81
        | "A82" -> Some A82
        | "A83" -> Some A83
        | "A84" -> Some A84
        | "A85" -> Some A85
        | "A86" -> Some A86
        | "A91" -> Some A91
        | "A92" -> Some A92
        | "A94" -> Some A94
        | "A96" -> Some A96
        | "A98" -> Some A98
        | "C15" -> Some C15
        | "D01" -> Some D01
        | "D02" -> Some D02
        | "D03" -> Some D03
        | "D04" -> Some D04
        | "D05" -> Some D05
        | "D06" -> Some D06
        | "D6W" -> Some D6W
        | "D07" -> Some D07
        | "D08" -> Some D08
        | "D09" -> Some D09
        | "D10" -> Some D10
        | "D11" -> Some D11
        | "D12" -> Some D12
        | "D13" -> Some D13
        | "D14" -> Some D14
        | "D15" -> Some D15
        | "D16" -> Some D16
        | "D17" -> Some D17
        | "D18" -> Some D18
        | "D20" -> Some D20
        | "D22" -> Some D22
        | "D24" -> Some D24
        | "E21" -> Some E21
        | "E25" -> Some E25
        | "E32" -> Some E32
        | "E34" -> Some E34
        | "E41" -> Some E41
        | "E45" -> Some E45
        | "E53" -> Some E53
        | "E91" -> Some E91
        | "F12" -> Some F12
        | "F23" -> Some F23
        | "F26" -> Some F26
        | "F28" -> Some F28
        | "F31" -> Some F31
        | "F35" -> Some F35
        | "F42" -> Some F42
        | "F45" -> Some F45
        | "F52" -> Some F52
        | "F56" -> Some F56
        | "F91" -> Some F91
        | "F92" -> Some F92
        | "F93" -> Some F93
        | "F94" -> Some F94
        | "H12" -> Some H12
        | "H14" -> Some H14
        | "H16" -> Some H16
        | "H18" -> Some H18
        | "H23" -> Some H23
        | "H53" -> Some H53
        | "H54" -> Some H54
        | "H62" -> Some H62
        | "H65" -> Some H65
        | "H71" -> Some H71
        | "H91" -> Some H91
        | "K32" -> Some K32
        | "K34" -> Some K34
        | "K36" -> Some K36
        | "K45" -> Some K45
        | "K56" -> Some K56
        | "K67" -> Some K67
        | "K78" -> Some K78
        | "N37" -> Some N37
        | "N39" -> Some N39
        | "N41" -> Some N41
        | "N91" -> Some N91
        | "P12" -> Some P12
        | "P14" -> Some P14
        | "P17" -> Some P17
        | "P24" -> Some P24
        | "P25" -> Some P25
        | "P31" -> Some P31
        | "P32" -> Some P32
        | "P36" -> Some P36
        | "P43" -> Some P43
        | "P47" -> Some P47
        | "P51" -> Some P51
        | "P56" -> Some P56
        | "P61" -> Some P61
        | "P67" -> Some P67
        | "P72" -> Some P72
        | "P75" -> Some P75
        | "P81" -> Some P81
        | "P85" -> Some P85
        | "R14" -> Some R14
        | "R21" -> Some R21
        | "R32" -> Some R32
        | "R35" -> Some R35
        | "R42" -> Some R42
        | "R45" -> Some R45
        | "R51" -> Some R51
        | "R56" -> Some R56
        | "R93" -> Some R93
        | "R95" -> Some R95
        | "T12" -> Some T12
        | "T23" -> Some T23
        | "T34" -> Some T34
        | "T45" -> Some T45
        | "T56" -> Some T56
        | "V14" -> Some V14
        | "V15" -> Some V15
        | "V23" -> Some V23
        | "V31" -> Some V31
        | "V35" -> Some V35
        | "V42" -> Some V42
        | "V92" -> Some V92
        | "V93" -> Some V93
        | "V94" -> Some V94
        | "V95" -> Some V95
        | "W12" -> Some W12
        | "W23" -> Some W23
        | "W34" -> Some W34
        | "W91" -> Some W91
        | "X35" -> Some X35
        | "X42" -> Some X42
        | "X91" -> Some X91
        | "Y14" -> Some Y14
        | "Y21" -> Some Y21
        | "Y25" -> Some Y25
        | "Y34" -> Some Y34
        | "Y35" -> Some Y35
        | _ -> None

    static member Create(value : string) =
        let trimmedValue = value |> Seq.map (fun c -> not(Char.IsWhiteSpace(c))) |> string
        let routingKey = Eircode.isValidRoutingKey(trimmedValue.Substring(0, 3))
        if routingKey.IsSome then
            Some(Eircode (routingKey.Value, trimmedValue.Substring(4)))
        else
            None

    member this.Display =
        match this with
        | Eircode(routingKey, id) -> printf "%A %s" routingKey id

    member this.Value =
        match this with 
        | Eircode(routingKey, id) -> printf "%A %s" routingKey id