   M S B A M L   `   `   `  ����D  @FrontDesk, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null%clr-namespace:FrontDesk	FrontDesk  5   	       FrontDesk.MainWindow   5   	   W SPresentationCore, Version=6.0.2.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=6.0.2.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35e aSystem.Windows.Controls.Ribbon, Version=6.0.2.0, Culture=neutral, PublicKeyToken=b77a5c561934e089R NWindowsBase, Version=6.0.2.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     5   	   R NSystem.Xaml, Version=6.0.2.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   )localclr-namespace:FrontDesk     5   	     � Title$  
MainWindow��5   	   $	��450��6   $
��1000��6)   .��5	      � .+�5
   
   �� -   5        $��reservationList��5
      $��
0,50,500,0q�6B   ��6*   ��  �� View 5      �� 5      P�5      �� 5       �� Width$ 50��6)   $��Id��64    �� DisplayMemberBinding 6@   ��  �� Path$ Id��� 5      $	 100��6)   $��Username��65    6G   �� $ Username��� 5      $	 100��6)   $��
Start date��65    6I   �� $ 	Startdate��� 5      $	 100��6)   $��End date��65    6G   �� $ Enddate��� 5      $	 100��6)   $��Status��65    6E   �� $ Status�5      5      �� 5   
   -   5        $��roomList��5      $��
500,50,0,0q�6;   ��6#   ��  5      �� 5      P�5      �� 5      $	 100��6)   $��Room number��65    6J   �� $ 
Roomnumber��� 5      $	 100��6)   $��	Room type��65    6H   �� $ Roomtype��� 5      $	 100��6)   $��Number of beds��65    6M   �� $ Numberofbeds��� 5      $	 100��6)   $��Reserved��65    6G   �� $ Reserved�5!      5#      �� 5$   
   -   5        $��searcRoomField��5$      $
��Left=�6)   $��
568,10,0,0q�6D    �� TextWrapping$
 Wrap=�6X   $�� ��6l   $	��Top=�6t   $	��120��6�   �� 5%   
   -   5        $��searchRoomButton��5%      $��Search��6)   $
��Left=�6:   $��
693,10,0,0q�6U   $	��Top=�6i    J� RenderTransformOrigin$ 
0.54,0.538&�6�   $��57��6�   6�   �� 5&   
   -   5        $��searchReservationButton��5&      $��Search��60   $
��Left=�6A   $��
135,10,0,0q�6\   $	��Top=�6p   $��65��6�   6�   �� 5'   
   -   5        $��searchReservationField��5'      $
��Left=�60   $��	10,10,0,0q�6K   $
 Wrap=�6^   $�� ��6r   $	��Top=�6z   $	��120��6�   �� 5(   
   -   5        $��Reservation Editor��5(      $
��Left=�6.   $��
205,10,0,0q�6I   $	��Top=�6]   $	��108��6u   6�   5)      5*      