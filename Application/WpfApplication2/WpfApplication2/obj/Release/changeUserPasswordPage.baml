   M S B A M L   `   `   `  ���� J  FWpfApplication2, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null1clr-namespace:WpfApplication2WpfApplication2  ,    &WpfApplication2.changeUserPasswordPage   R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35^ ZWindowsFormsIntegration, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     @d2http://schemas.microsoft.com/expression/blend/2008     /localclr-namespace:WpfApplication2       N� Title$  changeUserPasswordPage��.���  � RowDefinitions �� $
��Auto ��� $��* �.+��� $��Change Username/Password��$��1��$��Calibri)�$��22(�$��40,20,10,10q�$
��Bold"��� $��1��$��Center=�$��Center=�.+��  � ColumnDefinitions �� $��2* ��� $��4* � �� $
��Auto ��� $
��Auto ��� $
��Auto ��� $
��Auto ��� $
��Auto �.+��� -   $��userNameLabel��$��One Time Set UserName :��$��Right=�$��5,5,5,20q�$��16(��� $��Old Password :��$��Right=�$��1��$��5,5,5,20q�$��16(��� $��New Password :��$��Right=�$��2��$��5q�$��16(��� $��Re-Enter New Password :��$��Right=�$��3��$��5q�$��16(��� -   $��userNameTextBox��$��1��$��5,5,5,20q�$	��200��$
��Left=�$��16(�G� -   $��oldPasswTextBox��$��1��$��1��$��5,5,5,20q�$	��200��$
��Left=�$��16(�G� -   $��passwordTextBox��$��2��$��1��$��5,5,5,5q�$	��200��$
��Left=�$��16(�G� -   $��rePasswordTextBox��$��3��$��1��$��5,5,5,5q�$	��200��$
��Left=�$��16(��� -   $��saveNewButton��$��Change��$��1��$��4��$��	5,20,5,10q�$��25��$��75��$
��Left=��� -   $��
backButton��$
��Back��$��1��$��4��$��100,20,5,10q�$��25��$��75��$
��Left=�