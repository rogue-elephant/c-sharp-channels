# Channels
A play around with using channels in C#.

## GitHubIssues
Github api rate limit is 60 per hour for unauthenticated use.
Example output:
```
                            ---------------------------------------------
                            REPO: https://api.github.com/repos/rogue-elephant/json-conversion-tool
                            From User: rogue-elephant (Is Site Admin: False)
                            Issue:
                            Transformation strategies - standardize similar values

                            Add ability to specify transformations that can be performed during the conversion - standardizing similar values, only convert specific properties (whitelist and blacklist)

Standardize similar values (e.g. Hr, hr, HR -> HR)

                            ---------------------------------------------
                            REPO: https://api.github.com/repos/rogue-elephant/json-conversion-tool
                            From User: rogue-elephant (Is Site Admin: False)
                            Issue:
                            Prettify column names

                            change camelcase property names to sentence case

                            ---------------------------------------------
                            REPO: https://api.github.com/repos/rogue-elephant/json-conversion-tool
                            From User: rogue-elephant (Is Site Admin: False)
                            Issue:
                            Lookups

                            Ability to add lookups from within a complex JSON structure - for example if there are custom field definitions or enums specified in one place in the JSON and then the key for these referenced in later properties.

                            ---------------------------------------------
                            REPO: https://api.github.com/repos/rogue-elephant/json-conversion-tool
                            From User: rogue-elephant (Is Site Admin: False)
                            Issue:
                            Start from property

                            Need the ability to set a start from property probably needs to be by path to get to nested items.
This means that you can have a complex JSON but only iterate rows from some nested property within it rathe than the results being flattened to item_0, item_1 etc.

                            ---------------------------------------------
                            REPO: https://api.github.com/repos/rogue-elephant/json-conversion-tool
                            From User: rogue-elephant (Is Site Admin: False)
                            Issue:
                            Vs code extension

                            Create vs code extension that uses the json conversion tool - cmd palette > convert current file > choose output type

                            ---------------------------------------------
                            REPO: https://api.github.com/repos/rogue-elephant/json-conversion-tool
                            From User: rogue-elephant (Is Site Admin: False)
                            Issue:
                            JSON schema files

                            Ability to configure the conversion for schema files to output properties as markdown or markdown tables and to look up refs in other areas or files (this should work via the same mechanism as the lookups in task rogue-elephant/json-csv-tool#11 )

                            ---------------------------------------------
                            REPO: https://api.github.com/repos/rogue-elephant/migraine-tracker
                            From User: Gaminger (Is Site Admin: False)
                            Issue:
                            Weather /hay-fever integration

                            Integrate with users location weather report to record weather for around the time of migraine
Also record if pollen count was high/low (maybe this should be separate issue)

                            ---------------------------------------------
                            REPO: https://api.github.com/repos/rogue-elephant/migraine-tracker
                            From User: Gaminger (Is Site Admin: False)
                            Issue:
                            Adding details for migraine

                            A user should be able to to add the following to an event;
 Migraine severity 1-10
Have you drank enough today? Yes/No
Are you stressed/angry? Yes /No
What foods have you had? Multiple choice of: Lactose, caffeine, wheat, sugar etc (because free txt box is difficult to do analytics on later)

                            ---------------------------------------------
                            REPO: https://api.github.com/repos/rogue-elephant/migraine-tracker
                            From User: Gaminger (Is Site Admin: False)
                            Issue:
                            How many migraines in last x days

                            Shows an overview of how many migraines you had in the last X days/weeks/months/years

                            ---------------------------------------------
                            REPO: https://api.github.com/repos/rogue-elephant/migraine-tracker
                            From User: Gaminger (Is Site Admin: False)
                            Issue:
                            Interval between migraines

                            Shows when you had the last migraine to the current one.
To enable a quick overview how often migraine occurs and if there's a pattern

                            ---------------------------------------------
                            REPO: https://api.github.com/repos/rogue-elephant/migraine-tracker
                            From User: Gaminger (Is Site Admin: False)
                            Issue:
                            Edit details on migraine event

                            To enable editing of time, date of a migraine event later on. Also allow updating of weather or what food/drink was consumed

                            ---------------------------------------------
                            REPO: https://api.github.com/repos/rogue-elephant/migraine-tracker
                            From User: rogue-elephant (Is Site Admin: False)
                            Issue:
                            trigger detection

                            when a migraine is saved, the app should compare it with all previous migraine instances and use the various fields to detect any patterns and then add any potential triggers to the triggers page.

Each trigger should show the associated migraine instances (by most recent) - and the trigger list should be sorted by most common keyword across instances

                            ---------------------------------------------
                            REPO: https://api.github.com/repos/rogue-elephant/migraine-tracker
                            From User: rogue-elephant (Is Site Admin: False)
                            Issue:
                            Add a migraine event

                            Ability to add a migraine event that then shows up in the history list.
It should be possible to add this from the home screen and the list screen (or probably from ever screen really)

pressing the add button should show some sort of form that has a way to add the symptoms and pain areas from a drop down or checkbox (should be able to add more than one)

maybe show a toast notification or something when saving item

                            ---------------------------------------------
                            REPO: https://api.github.com/repos/rogue-elephant/json-schema-to-markdown-tool
                            From User: rogue-elephant (Is Site Admin: False)
                            Issue:
                            ref links in other schemas

                            add links to refs and link to another file if the reference is there

                            ---------------------------------------------
                            REPO: https://api.github.com/repos/rogue-elephant/json-schema-to-markdown-tool
                            From User: rogue-elephant (Is Site Admin: False)
                            Issue:
                            ref links within page

                            Turn $refs into links that lead to the actual reference

                            ---------------------------------------------
                            REPO: https://api.github.com/repos/rogue-elephant/json-schema-to-markdown-tool
                            From User: rogue-elephant (Is Site Admin: False)
                            Issue:
                            Examples

                            Ability to output actual examples of the schema in both JSON and YAML
```