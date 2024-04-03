
using CSCI5220SimpleDictionary.Models;

namespace CSCI5220SimpleDictionary.Services;

public interface IDictionaryRepository
{
    ICollection<DictionaryEntry> ReadAll();
    DictionaryEntry Create(DictionaryEntry entry);
}
