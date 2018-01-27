---


---

<h1 id="croneb">Croneb</h1>
<p>Em muitos momentos precisamos “<strong>chamar</strong>” scripts em determinados tempos,<br>
O intuito deste aplicativo é exatamente este.</p>
<h1 id="exemplo-de-uso">Exemplo de Uso</h1>
<ul>
<li>Preciso chamar o Site “<a href="http://www.teste1.com.br/cron.php">http://www.teste1.com.br/cron.php</a>” a cada <em>500 ms</em> com timeout máximo de <em>2 segs</em></li>
<li>Preciso chamar o Site “<a href="http://www.teste2.com.br/cron.php">http://www.teste2.com.br/cron.php</a>” a cada <em>5 segs</em> com timeout máximo de <em>20 segs</em></li>
</ul>
<p>Cada site é gerenciado por uma <strong>Thread</strong> independente, e uma rotina fica monitorando todas as Thread para checar se alguma parou de funcionar.</p>
<h2 id="requisitos">Requisitos</h2>
<ul>
<li><a href="https://www.microsoft.com/pt-br/download/details.aspx?id=30653">https://www.microsoft.com/pt-br/download/details.aspx?id=30653</a></li>
</ul>
<h2 id="testando">Testando</h2>
<p>Basta abrir o aplicativo compilado em <strong>Croneb/bin/Release/Croneb.exe</strong></p>
<h2 id="configurando">Configurando</h2>
<p>A configuração é feita através do arquivo <strong>Config.xml</strong> na mesma pasta onde esta o Croneb.exe<br>
Cada site que desejas chamar precisa possuir um nó semelhante ao nó abaixo:</p>
<pre class=" language-xml"><code class="prism  language-xml"><span class="token tag"><span class="token tag"><span class="token punctuation">&lt;</span>site</span><span class="token punctuation">&gt;</span></span>
    <span class="token tag"><span class="token tag"><span class="token punctuation">&lt;</span>Nome</span><span class="token punctuation">&gt;</span></span>teste1<span class="token tag"><span class="token tag"><span class="token punctuation">&lt;/</span>Nome</span><span class="token punctuation">&gt;</span></span>
    <span class="token tag"><span class="token tag"><span class="token punctuation">&lt;</span>Link</span><span class="token punctuation">&gt;</span></span>http://localhost:8080/teste1.php<span class="token tag"><span class="token tag"><span class="token punctuation">&lt;/</span>Link</span><span class="token punctuation">&gt;</span></span>
    <span class="token tag"><span class="token tag"><span class="token punctuation">&lt;</span>AbrirCada</span><span class="token punctuation">&gt;</span></span>1000<span class="token tag"><span class="token tag"><span class="token punctuation">&lt;/</span>AbrirCada</span><span class="token punctuation">&gt;</span></span>
    <span class="token tag"><span class="token tag"><span class="token punctuation">&lt;</span>Timeout</span><span class="token punctuation">&gt;</span></span>10000<span class="token tag"><span class="token tag"><span class="token punctuation">&lt;/</span>Timeout</span><span class="token punctuation">&gt;</span></span>
  <span class="token tag"><span class="token tag"><span class="token punctuation">&lt;/</span>site</span><span class="token punctuation">&gt;</span></span>
</code></pre>
<p>Os tempos armazenados em “<strong>AbrirCada</strong>” e “<strong>Timeout</strong>” estão em <em>Milissegundo</em></p>
<h2 id="imagem-do-aplicativo">Imagem do Aplicativo</h2>
<p><img src="https://cdn.pbrd.co/images/H4RhA4jj.png" alt="enter image description here"></p>

