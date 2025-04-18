#include "std_lib_facilities.h" // Use either this or standard headers, not both

int main()
{
    vector<string> words;

    // Read words from input
    for (string temp; cin >> temp;) {
        words.push_back(temp);
    }

    // Check for empty input
    if (words.empty()) {
        cout << "No words were entered.\n";
        return 0;
    }

    // Output the number of words
    cout << "Number of words entered: " << words.size() << '\n';

    // Sort the words
    sort(words);

    // Output unique sorted words
    cout << "Unique sorted words:\n";
    for (int i = 0; i < words.size(); ++i) {
        if (i == 0 || words[i - 1] != words[i]) {
            cout << words[i] << '\n';
        }
    }

    return 0;
}
