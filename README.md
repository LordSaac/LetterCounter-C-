# Letter Counter # 
_Search if there is a certain letter in a paragraph and find how many times it is repeated within the paragraph, in addition it returns all the letters found to a dictionary with its number of repetitions._
## Characteristic:

* Validate Exist of a letters in the paragraph. 
* Validates the number  of concurrence the one letter. 
* Save Dictionary of results. 

## Example

**Dictionary**

            Dictionary<string, int> dict = LCounter.getDictionary();
          
**Validate Exists:**
  > bool aux = LCounter.existLetter("E");

**Concurrence:**
> int count = LCounter.concurrenceLetter("E")

**[View Example Project](https://github.com/LordSaac/LetterCounter-C-/blob/master/Example/Program.cs)**

