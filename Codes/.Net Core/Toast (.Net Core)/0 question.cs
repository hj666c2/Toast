﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Discord;
using Discord.WebSocket;

namespace ToastBot
{
    class question
    {
        public async void anfdmavy(SocketMessage message)
        {
            var builder = new EmbedBuilder()
    .WithTitle("토스트가 사용 가능한 명령어들 (괄호 안은 사용법)")
    .WithDescription("토스트봇 깃헙 사이트는 [여기](https://github.com/hj666c2/Toast)\n\n\n")
    .WithColor(new Color(0x1e5aeb))
    .WithFooter(footer =>
    {
        footer
            .WithText("디스코드 뮤봇 C# Version")
            .WithIconUrl("https://cdn.discordapp.com/attachments/459706597841567746/521169622246883378/Bot_Profile.png")
    ;
    })
    .WithImageUrl("https://cdn.discordapp.com/attachments/459706597841567746/521169622246883378/Bot_Profile.png")
    .WithAuthor(author =>
    {
        author
            .WithName("PMH Studio / CS")
            .WithUrl("https://discordapp.com")
            .WithIconUrl("https://cdn.discordapp.com/attachments/459706597841567746/521169622246883378/Bot_Profile.png");
    })
    .AddField("토스트 (mu(뮤)!토스트)", "```토스트가 할 수 있는 것들을 보여준다뮤~```",true)
    .AddField("청소 (mu(뮤)!청소)", "```채팅방을 청소해준다뮤!```",true)
    .AddField("빵굽기 (mu(뮤)!빵굽기)", "```당신의 운을 시험해봐라뮤!\n만약 빵이 적당히 구워지면 투자가 가능한 빵이 된다뮤!```",true)
    .AddField("명예의 전당 (mu(뮤)!명예의전당 [0(한글), 1(영어)])", "```시즌별 1등과 1등이 가지고 있던 빵의 갯수를 DM으로 보내준다뮤!```",true)
    .AddField("주식투자 (mu(뮤)!주식투자 [매수, 매도, 가격] [주식투자이름] [주 수])","```주식투자를 한다뮤! 5분마다 주식 가격은 바뀐다뮤!```",true)
    .AddField("빵은행 (mu(뮤)!빵은행)", "```현재 가지고 있는 빵의 갯수를 보여준다뮤!```",true)
    .AddField("순위 (mu(뮤)!순위)", "```현재 당신이 몇 등인지 알려준다뮤!\n1등과 얼마나 차이가 나는지도 알려준다뮤~★```",true)
    .AddField("상위권 (mu(뮤)!상위권)", "```빵을 가장 많이 가지고 있는 사람의 1위~5위까지 보여준다뮤~```",true)
    .AddField("초대 (mu(뮤)!초대)", "```뮤봇을 초대 할 수 있는 링크를 보내준다뮤!```",true)
    .AddField(@"송금 (mu(뮤)!송금 {송금할사람(ID)(멘션)} (금액)","```지정한 사람에게 빵을 보내준다뮤!```")
    .AddField(@"환전 (mu(뮤)!환전 [빵으로/뮤트코인으로/가격] (빵개수))", "```뮤트코인과 빵을 환전시켜준다뮤! 단 가격은 수시로 바뀐다뮤~ (일정한 주기가 정해지진 않는다뮤!)```")
    .AddField("블랙 (mu(뮤)!블랙 (블랙할 사람))", "```(관리자 전용) 지정한 사람을 블랙리스트에 추가해버린다뮤! 만약에 그 사람이 토스트 명령어를 사용해보지 않았다면 안먹힌다뮤~```")
    .AddField("재시작 (mu(뮤)! 재시작)","```(관리자 전용) 토스트를 재시작한다뮤!```")
    .AddField("화이트 (mu(뮤)!화이트 (블랙한거를 풀 사람))","```(관리자 전용) 지정한 사람을 블랙리스트에서 뺀다뮤!```")
    .AddField("주의할 점", "```빵의 갯수를 저장하는 곳은 서버가 아니고 호스팅하는 사람의 컴퓨터 속에 있다뮤! \n그래서 서버가 달라도 빵은 계속 이어지고 순위 관련된 명령어는 다른 서버에 있는 사람도 포함한다뮤! \n만약에 이것를 원하지 않는다면 서버에 따라 봇을 새로 만들어서 코드를 집어넣는걸 추천한다뮤~~```")
    .AddField("개발중...","뭘 만들까뮤?");
            var embed = builder.Build();
            await message.Author.SendMessageAsync(
                "",
                embed: embed)
                .ConfigureAwait(true);
            await message.Channel.SendMessageAsync("DM을 확인해주세요");
        }
    }
}
