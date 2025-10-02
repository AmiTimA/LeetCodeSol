namespace LeetCode212_WordSearchII_Approach3;

// class Program
// {
//     static void Main(string[] args)
//     {
//         var solution = new Solution();
//         var board = new char[][]
//         {
//             new char[] { 'o', 'a', 'a', 'n' },
//             new char[] { 'e', 't', 'a', 'e' },
//             new char[] { 'i', 'h', 'k', 'r' },
//             new char[] { 'i', 'f', 'l', 'v' }
//         };
//         var words = new string[] { "oath", "pea", "eat", "rain" };
//         var result = solution.FindWords(board, words);
//         Console.WriteLine(string.Join(", ", result)); // Output: ["oath", "eat"]
//     }
// }
class TrieNode
{
    public TrieNode[] children = new TrieNode[26];
    public int idx = -1;
    public int refs = 0;
    public void AddWord(string word, int i)
    {
        TrieNode cur = this;
        cur.refs++;
        
        foreach (char c in word)
        {
            int index = c - 'a';
            if (cur.children[index] == null)
            {
                cur.children[index] = new TrieNode();
            }
            cur = cur.children[index];
            cur.refs++;
        }
        cur.idx = i;
    }
}
public class Solution
{
    private List<string> res = new List<string>();
    public List<string> FindWords(char[][] board, string[] words)
    {
        TrieNode root = new TrieNode();
        for (int i = 0; i < words.Length; i++)
        {
            root.AddWord(words[i], i);
        }
        for (int r = 0; r < board.Length; r++)
        {
            for (int c = 0; c < board[0].Length; c++)
            {
                Dfs(board, root, r, c, words);
            }
        }
        return res;
    }
    private void Dfs(char[][] board, TrieNode node, int r, int c, string[] words)
    {
        if (r < 0 || c < 0 || r >= board.Length || c >= board[0].Length || board[r][c] == '*' || node.children[board[r][c] - 'a'] == null)
        {
            return;
        }
        char temp = board[r][c];
        board[r][c] = '*';
        TrieNode prev = node;
        node = node.children[temp - 'a'];
        if (node.idx != -1)
        {
            res.Add(words[node.idx]);
            node.idx = -1;
            node.refs--;
            
            if (node.refs == 0)
            {
                node = null;
                prev.children[temp - 'a'] = null;
                board[r][c] = temp;
                return;
            }
        }
        Dfs(board, node, r + 1, c, words);
        Dfs(board, node, r - 1, c, words);
        Dfs(board, node, r, c + 1, words);
        Dfs(board, node, r, c - 1, words);
        board[r][c] = temp;
    }
}