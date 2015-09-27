namespace SReynolds.Types.Common

type EmailAddress = 
    private
    | EmailAddress of string
    static member private isValid (value: string) =
        let emailRegex = @"^(?("")(""[^""]+?""@)|(([0-9a-z]((\.(?!\.))|[-!#\$%&'\*\+/=\?\^`\{\}\|~\w])*)(?<=[0-9a-z])@))(?(\[)(\[(\d{1,3}\.){3}\d{1,3}\])|(([0-9a-z][-\w]*[0-9a-z]*\.)+[a-z0-9]{2,17}))$"
        System.Text.RegularExpressions.Regex.IsMatch(value, emailRegex)
    static member Create(address: string) =
        if EmailAddress.isValid address then
            Some(EmailAddress address)
        else
            None
    member this.Value =
        match this with 
        | EmailAddress value -> value