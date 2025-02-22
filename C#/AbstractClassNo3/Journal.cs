using System.Collections.Generic;
using System.Text;

public class Journal
{
    private List<JournalEntry> entries = new List<JournalEntry>();

    public void AddEntry(object source, CollectionHandlerEventArgs args)
    {
        entries.Add(new JournalEntry(args.CollectionName, args.ChangeType, args.ChangedObject?.ToString()));
    }

    public override string ToString()
    {
        var builder = new StringBuilder();
        foreach (var entry in entries)
        {
            builder.AppendLine(entry.ToString());
        }
        return builder.ToString();
    }
}
