<template>
  <div id="snow">
    <section class="hero is-fullheight">
      <!-- Hero head: will stick at the top -->
      <div class="hero-head">
        <nav class="navbar">
          <div class="container">
            <div class="navbar-brand">
              <a class="navbar-item">
              </a>
              <span class="navbar-burger burger" data-target="navbarMenuHeroA">
                <span></span>
                <span></span>
                <span></span>
              </span>
            </div>
          </div>
        </nav>
      </div>

      <!-- Hero content: will be in the middle -->
      <div class="has-text-centered">
        <h1 class="title" id="title">Smithtown Fire Department</h1>
      </div>      
      <div class="hero-body">
        <div class="container has-text-centered">
          <router-view></router-view>
        </div>
      </div>

      <!-- Hero footer: will stick at the bottom -->
      <div class="hero-foot">
        <nav class="tabs">
          <div class="container">

          </div>
        </nav>
      </div>
    </section>
  </div>
</template>

<script>
export default {
  name: 'app',
  data () {
    return {
      navbarMenuHeroC: false
    }
  },
  computed: {
    screenWidth () {
      return window.screen.width
    }
  },
  mounted () {
    if (this.$route.name !== 'tracker') {
      this.$router.push({name: 'christmasParadeCountdown'})
    }
  }
}
</script>

<style>
@import '~bulma/css/bulma.css';

#title,#subtitle {
  color:#ff0000;
  text-transform: uppercase;
}

#snow{
  display: -ms-flexbox;
  display: flex;
  -webkit-box-orient: horizontal;
  -webkit-box-direction: normal;
      -ms-flex-flow: row wrap;
          flex-flow: row wrap;
  -webkit-box-pack: center;
      -ms-flex-pack: center;
          justify-content: center;
  -webkit-box-align: stretch;
      -ms-flex-align: stretch;
          align-items: stretch;
	background: none;
	font-family: Androgyne;
	height: 100%;
	left: 0;
	position: absolute;
	top: 0;
	width: 100%;
	z-index:1;
	background-color:rgba(0, 15, 47, 0.9490196078431372); 
	background-image: url('assets/snow.png'), url('assets/snow2.png'), url('assets/snow3.png');
	-webkit-animation: snow 20s linear infinite;
	animation: snow 20s linear infinite;
}
@keyframes snow {
0% {background-position: 0px 0px, 0px 0px, 0px 0px;}
100% {background-position: 500px 1000px, 400px 400px, 300px 300px;}
}

@-webkit-keyframes snow {
0% {background-position: 0px 0px, 0px 0px, 0px 0px;}
100% {background-position: 500px 1000px, 400px 400px, 300px 300px;}
}

@-webkit-keyframes even-flash {
  0%, 100%{
    background: rgba(75, 255, 65, 0.9);
    -webkit-box-shadow: 0 2px 20px 4px rgba(53, 218, 34, 0.9098039215686274);
            box-shadow: 0 2px 20px 4px rgba(53, 218, 34, 0.9098039215686274)
  }
  50%{
    background: rgba(75, 255, 65, 0.9);
    -webkit-box-shadow: 0 2px 20px 4px rgba(76, 255, 65, 0.48);
            box-shadow: 0 2px 20px 4px rgba(76, 255, 65, 0.48);
  }
}

@keyframes even-flash {
  0%, 100%{
    background: rgba(75, 255, 65, 0.9);
    -webkit-box-shadow: 0 2px 20px 4px rgba(53, 218, 34, 0.9098039215686274);
            box-shadow: 0 2px 20px 4px rgba(53, 218, 34, 0.9098039215686274)
  }
  50%{
    background: rgba(75, 255, 65, 0.9);
    -webkit-box-shadow: 0 2px 20px 4px rgba(76, 255, 65, 0.48);
            box-shadow: 0 2px 20px 4px rgba(76, 255, 65, 0.48);
  }
}

@-webkit-keyframes odd-flash {
  50%{
    background: #e20c0b;
    -webkit-box-shadow: 0 2px 20px 4px #ff0000;
            box-shadow: 0 2px 20px 4px #ff0000; 
  }
  0%, 100%{
    background: #e20c0b;
    -webkit-box-shadow: 0 2px 20px 4px rgba(234, 21, 21, 0.3);
            box-shadow: 0 2px 20px 4px rgba(234, 21, 21, 0.3);
  }
}

@keyframes odd-flash {
  50%{
    background: #e20c0b;
    -webkit-box-shadow: 0 2px 20px 4px #ff0000;
            box-shadow: 0 2px 20px 4px #ff0000; 
  }
  0%, 100%{
    background: #e20c0b;
    -webkit-box-shadow: 0 2px 20px 4px rgba(234, 21, 21, 0.3);
            box-shadow: 0 2px 20px 4px rgba(234, 21, 21, 0.3);
  }
}
</style>
