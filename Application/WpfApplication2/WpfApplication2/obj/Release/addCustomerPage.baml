   M S B A M L   `   `   `  ���� J  FWpfApplication2, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null1clr-namespace:WpfApplication2WpfApplication2  %    WpfApplication2.addCustomerPage   R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35^ ZWindowsFormsIntegration, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     @d2http://schemas.microsoft.com/expression/blend/2008     /localclr-namespace:WpfApplication2       N� Title$  addCustomerPage��.���  � RowDefinitions �� $
��Auto ��� $��* �.+��� $��New Customer��$��1��$��Calibri)�$��22(�$��40,20,10,10q�$
��Bold"��� $��1��$��Center=�$��Center=�.+��  � ColumnDefinitions �� $��2* ��� $��4* � �� $
��Auto ��� $
��Auto ��� $
��Auto ��� $
��Auto ��� $
��Auto ��� $
��Auto ��� $
��Auto �.+��� $��Store Name :��$��Right=�$��5q�$��16(��� $��Owner :��$��Right=�$��1��$��5q�$��16(��� $��Mobile :��$��Right=�$��2��$��5q�$��16(��� $��	Address :��$��Right=�$��3��$��5q�$��16(��� $��Email :��$��Right=�$��4��$��5q�$��16(��� -   $��storeNameTextBox��$��1��$��5,5,5,10q�$	��200��$
��Left=�$��16(��� -   $��ownerTextBox��$��1��$��1��$��5,5,5,10q�$	��200��$
��Left=�$��16(��� -   $��mobileTextBox��$��2��$��1��$��5,5,5,10q�$	��200��$
��Left=�$��16(� �� 	MaxLength$ 10���� -   $��addressTextBox��$��3��$��1��$��5,5,5,10q�$	��200��$
��Left=�$��16(� �� MinLines$ 5�� �� TextWrapping$
 Wrap=��� -   $��emailTextBox��$��4��$��1��$��5,5,5,10q�$	��200��$
��Left=�$��16(��� -   $��saveNewCustomerButton��$
��Save��$��1��$��5��$��	5,20,5,10q�$��25��$��75��$
��Left=��� -   $��errorMessage��$�� ��$��1��$��6��
���  ��