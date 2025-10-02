namespace LeetCode208;

// class Program
// {
//     static void Main(string[] args)
//     {
//         Trie obj = new Trie();
//         obj.Insert("apple");
//         Console.WriteLine($"apple: {obj.Search("apple")}");   // return True
//         Console.WriteLine($"app: {obj.Search("app")}");     // return False
//         Console.WriteLine($"app: {obj.StartsWith("app")}"); // return True
//     }
// }

public class Node
{
    public Node[] children = new Node[26];
    public bool endOfWord = false;
}

public class Trie
{
    Node root = null;

    public Trie()
    {
        root = new Node();
    }

    public void Insert(string word)
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
        Node cur = root;

        foreach (char c in word)
        {
            Node child = cur.children[GetCharIndex(c)];

            if (child == null)
            {
                return false;
            }

            cur = cur.children[GetCharIndex(c)];
        }

        return cur.endOfWord;
    }

    public bool StartsWith(string prefix)
    {
        Node cur = root;

        foreach (char c in prefix)
        {
            Node child = cur.children[GetCharIndex(c)];

            if (child == null)
            {
                return false;
            }

            cur = cur.children[GetCharIndex(c)];
        }

        return true;
    }

    private static int GetCharIndex(char c)
    {
        return c - 'a';
    }
}
