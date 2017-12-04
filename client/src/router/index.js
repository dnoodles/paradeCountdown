import Vue from 'vue'
import Router from 'vue-router'
import christmasParadeCountdown from '@/components/christmasParadeCountdown'

Vue.use(Router)

export default new Router({
  routes: [
    {
      path: '/',
      name: 'christmasParadeCountdown',
      component: christmasParadeCountdown
    }
  ]
})
