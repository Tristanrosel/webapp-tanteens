using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

public class IndexModel : PageModel
{
    [BindProperty]
    public string InputString { get; set; }

    public string CopiedString { get; set; }

    public int CharactersCopied { get; set; }

    public IActionResult OnPost()
    {
        CopiedString = CopyString(InputString);
        CharactersCopied = InputString.Length;
        return Page();
    }

    private string CopyString(string str)
    {
        return str;
    }
}
