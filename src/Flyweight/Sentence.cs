using System.Text;

namespace Flyweight
{
    public class Sentence
    {
        private Dictionary<int, WordToken>? _tokens;

        private readonly List<string> _plainTextList;

        public Sentence(string plainText)
        {
            _plainTextList = plainText.Split(" ").ToList();
        }

        public WordToken this[int index]
        {
            get
            {
                _tokens ??= new();
                _tokens.Add(index, new WordToken());
                return _tokens[index];
            }
        }

        public override string? ToString()
        {
            var sb = new StringBuilder();

            _plainTextList.ForEach(word => sb.Append(_tokens is not null && _tokens.ContainsKey(_plainTextList.IndexOf(word)) ?
                GetWordUpperOrNot(word) : word)
            .Append(' '));

            return sb.ToString().Trim();
        }

        private string GetWordUpperOrNot(string word)
        {
            return _tokens![_plainTextList.IndexOf(word)].Capitalize ? word.ToUpper() : word;
        }

        public class WordToken
        {
            public bool Capitalize { get; set; }
        }
    }
}
