   M S B A M L   `   `   `  ����J  FWpfApplication2, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null1clr-namespace:WpfApplication2WpfApplication2  5      ,    &WpfApplication2.changeUserPasswordPage   5      R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35^ ZWindowsFormsIntegration, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     5      R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5      Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5      @d2http://schemas.microsoft.com/expression/blend/2008     5      /localclr-namespace:WpfApplication2     5        N� Title$  changeUserPasswordPage��5	      .��5      �  � RowDefinitions 5   
   �� 5      $
��Auto �6   �� 5      $��* �6   .+�5   
   �� $��Change Username/Password��6   $��1��64   $��Calibri)�6D   $��22(�6Y   $��40,20,10,10q�6g   $
��Bold"�6|   �� 5   
   $��1��6   $��Center=�6"   $��Center=�6=   .+�5      �  � ColumnDefinitions 5      �� 5      $��2* �6'   �� 5      $��4* �6'    5      �� 5      $
��Auto �6$   �� 5      $
��Auto �6$   �� 5      $
��Auto �6$   �� 5      $
��Auto �6$   �� 5      $
��Auto �6$   .+�5      �� -   5        $��userNameLabel��5      $��One Time Set UserName :��6-   $��Right=�6O   $��5,5,5,20q�6k   $��16(�6}   �� 5      $��Old Password :��6   $��Right=�61   $��1��6M   $��5,5,5,20q�6Z   $��16(�6l   �� 5       $��New Password :��6   $��Right=�61   $��2��6M   $��5q�6Z   $��16(�6e   �� 5!      $��Re-Enter New Password :��6   $��Right=�6:   $��3��6V   $��5q�6c   $��16(�6n   �� 5$      -   5        $��userNameTextBox��5$      $��1��61   $��5,5,5,20q�6A   $	��200��6S   $
��Left=�6_   $��16(�6z   G� 5%      -   5        $��oldPasswTextBox��5%      $��1��66   $��1��6C   $��5,5,5,20q�6T   $	��200��6f   $
��Left=�6r   $��16(�6�   G� 5&      -   5        $��passwordTextBox��5&      $��2��65   $��1��6B   $��5,5,5,5q�6S   $	��200��6d   $
��Left=�6p   $��16(�6�   G� 5'      -   5        $��rePasswordTextBox��5'      $��3��67   $��1��6D   $��5,5,5,5q�6U   $	��200��6f   $
��Left=�6r   $��16(�6�   �� 5(      -   5        $��saveNewButton��5(      $��Change��6.   $��1��6?   $��4��6O   $��	5,20,5,10q�6\   $��25��6o   $��75��6{   $
��Left=�6�   6�   �� 5)      -   5        $��
backButton��5)      $
��Back��6+   $��1��6:   $��4��6J   $��100,20,5,10q�6W   $��25��6l   $��75��6x   $
��Left=�6�   6�   5+      5-      5.      50      