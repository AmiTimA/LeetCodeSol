// Design HashMap
// https://leetcode.com/explore/learn/card/hash-table/182/practical-applications/1140/

// ToDo: Code not finished yet.

class MyHashMap {
    const int MAX_LEN = 1000000;             // the amount of buckets
    List<KeyValuePair<int, int>>[] map;     // hash map implemented by array
    
    /** Returns the corresponding bucket index. */
    private int getIndex(int key) {
        return key % MAX_LEN;
    }
    
    /** Search the key in a specific bucket. Returns -1 if the key does not existed. */
    private int getPos(int key, int index) {
        // Each bucket contains a list.
        List<KeyValuePair<int, int>> tempList = map[index];
       
        if (tempList == null) {
            return -1;
        }
        
        // Iterate all the elements in the bucket to find the target key.
        for (int i = 0; i < tempList.Count; i++) {
            if (tempList[i].Key == key) {
                return i;
            }
        }
        return -1;
    }

    /** Initialize your data structure here. */
    public MyHashMap() {
        map = new List<KeyValuePair<int, int>>[MAX_LEN];
    }
    
    /** value will always be positive. */
    public void put(int key, int value) {
        int index = getIndex(key);
        int pos = getPos(key, index);
        
        if (pos < 0) {
            // Add new (key, value) pair if key is not existed.
            if (map[index] == null) {
                map[index] = new List<KeyValuePair<int, int>>();
            }
            map[index].Add(new KeyValuePair(key, value));
        } else {
            // Update the value if key is existed.
            map[index].set(pos, new Pair(key, value));
        }
    }
    
    /** Returns the value to which the specified key is mapped, or -1 if this map contains no mapping for the key */
    public int get(int key) {
        int index = getIndex(key);
        int pos = getPos(key, index);
        if (pos < 0) {
            return -1;
        } else {
            return map[index].get(pos).getValue();
        }
    }
    
    /** Removes the mapping of the specified value key if this map contains a mapping for the key */
    public void remove(int key) {
        int index = getIndex(key);
        int pos = getPos(key, index);
        if (pos >= 0) {
            map[index].remove(pos);
        }
    }
}

/**
 * Your MyHashMap object will be instantiated and called as such:
 * MyHashMap obj = new MyHashMap();
 * obj.put(key,value);
 * int param_2 = obj.get(key);
 * obj.remove(key);
 */