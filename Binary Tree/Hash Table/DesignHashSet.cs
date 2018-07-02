// Design HashSet
// https://leetcode.com/explore/learn/card/hash-table/182/practical-applications/1139/

public class MyHashSet {
    const int MAX_LEN = 1000000;
    List<int>[] set;
    
    private int GetIndex(int key){
        return key % MAX_LEN;
    }
    
    private int GetPosition(int key, int index){
        List<int> templist = set[index];
        if (templist == null)
            return -1;
        
        for (int i = 0; i < templist.Count; i++){
            if(templist[i] == key)
                return i;
        }
        
        return -1;
    }
    
    /** Initialize your data structure here. */
    public MyHashSet() {
        set = new List<int>[1000000];
    }
    
    public void Add(int key) {
        int index = GetIndex(key);
        int position = GetPosition(key, index);
        
        if(position == -1){
            if(set[index] == null){
                set[index] = new List<int>();
            }
            set[index].Add(key);
        }
    }
    
    public void Remove(int key) {
        int index = GetIndex(key);
        if(set[index] != null){
            set[index].Remove(key);
        }
    }
    
    /** Returns true if this set did not already contain the specified element */
    public bool Contains(int key) {
        int index = GetIndex(key);
        if(set[index] != null){
            return set[index].Contains(key);
        }
        return false;
    }
}

/**
 * Your MyHashSet object will be instantiated and called as such:
 * MyHashSet obj = new MyHashSet();
 * obj.Add(key);
 * obj.Remove(key);
 * bool param_3 = obj.Contains(key);
 */