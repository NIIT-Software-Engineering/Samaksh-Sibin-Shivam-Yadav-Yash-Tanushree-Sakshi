   M S B A M L   `   `   `  ����J  FWpfApplication2, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null1clr-namespace:WpfApplication2WpfApplication2  5   	        WpfApplication2.MainWindow   5   	   R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35^ ZWindowsFormsIntegration, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   /localclr-namespace:WpfApplication2     5   	   -   5        $��
mainWindow��5   	     � Title$  
MainWindow��5   	   $	��600��6   $	��800��6)   $	��600��65   $	��800��6E    � WindowStartupLocation$ CenterScreen=�6T   .��5      � 
������� � RowDefinitions 5   
   �� 5      $
��Auto �6   �� 5      $
��Auto �6   �� 5      $��* �6   .+�5   
   � ���#4646ff.+�5      �� -   5        $��headingText��5   4   
�������$��	ExtraBold"�6G   $��Project Software��6^   $��0��6v   $��Center=�6�   $��30(�6�   $��	0,20,0,10q�6�   $��Calibri)�6�   5      � 5   
   -   5        $��tabGrid��5      $��1��6   $y�	Collapsed=�6+    � ColumnDefinitions 5      �� 5      $��1* �6#   �� 5      $��1* �6#   �� 5      $��1* �6#   �� 5      $��1* �6#   �� 5      $��1* �6#   �� 5      $��1* �6#   �� 5      $��1* �6#   .+�5       �� -   5        $��
homeButton��5       
����������#3232ff$
��Home��6O   $
��Bold"�6^   6p   �� 5!      -   5        $��billBookButton��5!      
����������#3232ff$��	Bill Book��6S   $��1��6g   $
��Bold"�6w   6�   �� 5"      -   5        $��wareHouseButton��5"      
�������$��	WareHouse��6?   ���#3232ff$��2��6h   $
��Bold"�6x   6�   �� 5#      -   5        $��customerButton��5#      
�������$��Customer��6>   $��3��6Q   ���#3232ff$
��Bold"�6v   6�   �� 5$      -   5        $��supplyButton��5$      
�������$��Supply��6<   $��4��6M   ���#3232ff$
��Bold"�6r   6�   �� 5%      -	   5        $��	logButton��5%      
�������$	��Log��69   $��5��6G   ���#3232ff$
��Bold"�6l   6~   �� 5&      -
   5        $��ledgerButton��5&      
�������$��Ledger��6<   $��6��6M   ���#3232ff$
��Bold"�6r   6�   5'       � 5)   
   -   5        $��myFrame��5)      $��2��6   6,   5,      5/      