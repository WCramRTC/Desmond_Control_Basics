# Desmond_Control_Basics

In .NET MAUI, the equivalent controls for the standard UI elements you mentioned are as follows:

1. **Label:**
   In .NET MAUI, you can use the `Label` control to display text or provide descriptive labels. Here's an example:

   ```csharp
   <Label Text="This is a label" />
   ```

2. **TextBox (Entry):**
   In .NET MAUI, the equivalent of a TextBox is the `Entry` control. It allows users to input text:

   ```csharp
   <Entry Placeholder="Enter text here" />
   ```

3. **Button:**
   To create a button in .NET MAUI, you can use the `Button` control:

   ```csharp
   <Button Text="Click me" />
   ```

4. **Rich Text Box (Editor):**
   For rich text input, you can use the `Editor` control in .NET MAUI:

   ```csharp
   <Editor Placeholder="Type rich text here" />
   ```

5. **CheckBox:**
   In .NET MAUI, the equivalent of a CheckBox is the `CheckBox` control:

   ```csharp
   <CheckBox IsChecked="true" />
   ```

6. **RadioButton:**
   For radio button-like behavior, you can use the `RadioButton` control. It's often used in combination with a `StackLayout` to create radio button groups:

   ```csharp
   <StackLayout>
       <RadioButton Content="Option 1" />
       <RadioButton Content="Option 2" />
   </StackLayout>
   ```

7. **ListBox (ListView):**
   In .NET MAUI, the equivalent of a ListBox is the `ListView` control. You can use it to display a list of items:

   ```csharp
   <ListView>
       <!-- Populate list items here -->
   </ListView>
   ```

8. **ComboBox (Picker):**
   To create a combo box-like control in .NET MAUI, you can use the `Picker` control. It provides a dropdown list of options:

   ```csharp
   <Picker Title="Select an option">
       <Picker.ItemsSource>
           <x:String>Option 1</x:String>
           <x:String>Option 2</x:String>
           <!-- Add more options here -->
       </Picker.ItemsSource>
   </Picker>
   ```

These controls should cover the basic UI elements you mentioned, and you can customize their appearance and behavior further as needed for your .NET MAUI app.