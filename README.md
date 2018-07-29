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

Copyright 2018 Isaac G. Banda

Licensed under the Apache License, Version 2.0 (the "License");
you may not use this file except in compliance with the License.
You may obtain a copy of the License at

    http://www.apache.org/licenses/LICENSE-2.0

Unless required by applicable law or agreed to in writing, software
distributed under the License is distributed on an "AS IS" BASIS,
WITHOUT WARRANTIES OR CONDITIONS OF ANY KIND, either express or implied.
See the License for the specific language governing permissions and
limitations under the License.
