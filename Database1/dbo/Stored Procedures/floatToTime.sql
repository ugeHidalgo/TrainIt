CREATE procedure [dbo].[floatToTime] @timeAsFloat float, @totTimeVC varchar(14) output
as

declare @h int;
declare @m int;
declare @s int;

set @h=CAST(@timeAsFloat/3600 as int);
set @m=CAST( (CAST(@timeAsFloat as Int)%3600)/60 as int);
set @s=(CAST(@timeAsFloat as Int)%3600)%60;

declare @mVC varchar(2);
declare @sVC varchar(2);
set @mVC=Convert(varchar(2),@m);
set @sVC=Convert(varchar(2),@s);

if LEN(@mVC)=1
begin
	set @mVC='0'+@mVC;
end;
if LEN(@sVC)=1
begin
	set @sVC='0'+@sVC;
end;

set @totTimeVC=Convert(varchar(8),@h)+':'+@mVC+':'+@sVC;