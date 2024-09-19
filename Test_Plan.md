Test Plan

A. Functional Testing

| Test Case ID | Description                                       | Input            | Expected Output                                                                          | Status |
|--------------|---------------------------------------------------|------------------|------------------------------------------------------------------------------------------|--------|
| TC-01        | Convert whole number without decimal              | "123"            | "ONE HUNDRED TWENTY-THREE DOLLARS"                                                       |   Y    |
| TC-02        | Convert number with decimal                       | "123.45"         | "ONE HUNDRED TWENTY-THREE DOLLARS AND FORTY-FIVE CENTS"                                  |   Y    |
| TC-03        | Convert four digit                                | "1234"           | "ONE THOUSAND TWO HUNDRED THIRTY-FOUR DOLLARS"                                           |   Y    |
| TC-04        | Convert five digit                                | "12345"          | "TWELVE THOUSAND THREE HUNDRED FORTY-FIVE DOLLARS"                                       |   Y    |
| TC-05        | Convert six digit                                 | "123456"         | "ONE HUNDRED TWENTY-THREE THOUSAND FOUR HUNDRED FIFTY-SIX DOLLARS"                       |   Y    |
| TC-06        | Convert seven digit                               | "1234567"        | "ONE MILLION TWO HUNDRED THIRTY-FOUR THOUSAND FIVE HUNDRED SIXTY-SEVEN DOLLARS"          |   Y    |
| TC-07        | Convert negative number                           | "-123"           | "MINUS ONE HUNDRED TWENTY-THREE DOLLARS"                                                 |   Y    |
| TC-08        | Convert negative number with decimal              | "-123.45"        | "MINUS ONE HUNDRED TWENTY-THREE DOLLARS AND FORTY-FIVE CENTS"                            |   Y    |
| TC-09        | Convert zero                                      | "0"              | "ZERO"                                                                                   |   Y    |

B. Boundary Testing

| Test Case ID | Description                                       | Input            | Expected Output                                                                                                                        | Status |
|--------------|---------------------------------------------------|------------------|----------------------------------------------------------------------------------------------------------------------------------------|--------|
| TC-10        | Test maximum value supported                      | "2147483647.99"  | "TWO BILLION ONE HUNDRED FORTY-SEVEN MILLION FOUR HUNDRED EIGHTY-THREE THOUSAND SIX HUNDRED FORTY-SEVEN DOLLARS AND NINETY-NINE CENTS" |   Y    |
