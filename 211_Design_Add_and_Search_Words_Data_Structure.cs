namespace LeetCode211;

// class Program
// {
//     static void Main(string[] args)
//     {
//         WordDictionary wordDictionary = new WordDictionary();
//         wordDictionary.AddWord("bad");
//         wordDictionary.AddWord("dad");
//         wordDictionary.AddWord("mad");
//         Console.WriteLine(wordDictionary.Search("pad")); // false
//         Console.WriteLine(wordDictionary.Search("bad")); // true
//         Console.WriteLine(wordDictionary.Search(".ad")); // true
//         Console.WriteLine(wordDictionary.Search("b..")); // true
//     }
// }

public class Node
{
    public Node[] children = new Node[26];
    public bool endOfWord = false;
}

public class WordDictionary
{
    Node root = null;

    public WordDictionary()
    {
        root = new Node();
    }

    public void AddWord(string word)
    {
        Node cur = root;

        foreach (char c in word)
        {
            Node child = cur.children[GetCharIndex(c)];

            if (child == null)
            {
                cur.children[GetCharIndex(c)] = new Node();
            }

            cur = cur.children[GetCharIndex(c)];
        }

        cur.endOfWord = true;
    }

    public bool Search(string word)
    {
        return Search(word, root, 0);
    }
    
    // Backtracking
    public bool Search(string word, Node root, int index)
    {
        Node cur = root;

        for (int i = index; i < word.Length; i++)
        {
            char c = word[i];

            if (c == '.')
            {
                foreach (Node child1 in cur.children)
                {
                    if (child1 != null && Search(word, child1, i + 1))
                    {
                        return true;
                    }
                }

                return false;
            }
            else
            {
                Node child = cur.children[GetCharIndex(c)];

                if (child == null)
                {
                    return false;
                }

                cur = child;
            }
        }

        return cur.endOfWord;
    }

    private int GetCharIndex(char c)
    {
        return c - 'a';
    }
}